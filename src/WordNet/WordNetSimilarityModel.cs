using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LAIR.ResourceAPIs.WordNet;
using LAIR.Collections.Generic;

namespace LAIR.ResourceAPIs.WordNet
{
    /// <summary>
    /// Provides WordNet-based semantic similarity measures
    /// </summary>
    public class WordNetSimilarityModel
    {
        #region static members
        /// <summary>
        /// Similarity strategies
        /// </summary>
        public enum Strategy
        {
            /// <summary>
            /// Follow the method described by Wu and Palmer (1994):  2 * depth(lcs) / (depth(s1) + depth(s2)). When multiple
            /// synsets are available, the most common sense are used.
            /// </summary>
            WuPalmer1994MostCommon,

            /// <summary>
            /// Follow the method described by Wu and Palmer (1994):  2 * depth(lcs) / (depth(s1) + depth(s2)). When multiple
            /// synsets are available, the ones resulting in minimum similarity are used.
            /// </summary>
            WuPalmer1994Minimum,

            /// <summary>
            /// Follow the method described by Wu and Palmer (1994):  2 * depth(lcs) / (depth(s1) + depth(s2)). When multiple
            /// synsets are available, the ones resulting in maximum similarity are used.
            /// </summary>
            WuPalmer1994Maximum,

            /// <summary>
            /// Follow the method described by Wu and Palmer (1994):  2 * depth(lcs) / (depth(s1) + depth(s2)). When multiple
            /// synsets are available, similarity is averaged across all synsets.
            /// </summary>
            WuPalmer1994Average
        }
        #endregion

        private WordNetEngine _wordNetEngine;

        /// <summary>
        /// Gets the WordNet engine for this model
        /// </summary>
        public WordNetEngine WordNetEngine
        {
            get { return _wordNetEngine; }
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="wordNetEngine">WordNet engine to use</param>
        public WordNetSimilarityModel(WordNetEngine wordNetEngine)
        {
            _wordNetEngine = wordNetEngine;
        }

        /// <summary>
        /// Gets similarity of two strings using the most common synset for given string/pos pairs
        /// </summary>
        /// <param name="string1">First string</param>
        /// <param name="pos1">First POS</param>
        /// <param name="pos2">Second POS</param>
        /// <param name="string2">Second string</param>
        /// <param name="strategy">Similarity strategy to use</param>
        /// <param name="relations">Relations to use when computing similarity</param>
        /// <returns>Similarity</returns>
        public float GetSimilarity(string string1, WordNetEngine.POS pos1, string string2, WordNetEngine.POS pos2, Strategy strategy, params WordNetEngine.SynSetRelation[] relations)
        {
            float similarity = 0;

            if (strategy == Strategy.WuPalmer1994Average)
            {
                // get average similarity across all synsets
                int numScores = 0;
                foreach (SynSet synset1 in _wordNetEngine.GetSynSets(string1, pos1))
                    foreach (SynSet synset2 in _wordNetEngine.GetSynSets(string2, pos2))
                    {
                        similarity += GetSimilarity(synset1, synset2, strategy, relations);
                        ++numScores;
                    }

                if (numScores > 0)
                    similarity = similarity / (float)numScores;
            }
            else if (strategy == Strategy.WuPalmer1994Maximum)
            {
                // get maximum similarity across all synsets
                foreach (SynSet synset1 in _wordNetEngine.GetSynSets(string1, pos1))
                    foreach (SynSet synset2 in _wordNetEngine.GetSynSets(string2, pos2))
                    {
                        float currSim = GetSimilarity(synset1, synset2, strategy, relations);
                        if (currSim > similarity)
                            similarity = currSim;
                    }
            }
            else if (strategy == Strategy.WuPalmer1994Minimum)
            {
                // get minimum similarity across all synsets
                similarity = -1;
                foreach (SynSet synset1 in _wordNetEngine.GetSynSets(string1, pos1))
                    foreach (SynSet synset2 in _wordNetEngine.GetSynSets(string2, pos2))
                    {
                        float currSim = GetSimilarity(synset1, synset2, strategy, relations);
                        if (similarity == -1 || currSim < similarity)
                            similarity = currSim;
                    }

                // if we didn't find any synsets, similarity is zero
                if (similarity == -1)
                    similarity = 0;
            }
            else if (strategy == Strategy.WuPalmer1994MostCommon)
            {
                // use most common synsets
                SynSet synset1 = _wordNetEngine.GetMostCommonSynSet(string1, pos1);
                SynSet synset2 = _wordNetEngine.GetMostCommonSynSet(string2, pos2);

                if (synset1 != null && synset2 != null)
                    similarity = GetSimilarity(synset1, synset2, strategy, relations);
            }
            else
                throw new NotImplementedException("Unimplemented strategy:  " + strategy);

            if (similarity < 0 || similarity > 1)
                throw new Exception("Invalid similarity:  " + similarity);

            return similarity;
        }

        /// <summary>
        /// Gets similarity of two synsets
        /// </summary>
        /// <param name="synset1">First synset</param>
        /// <param name="synset2">Second synset</param>
        /// <param name="strategy">Strategy to use. All strategies named WuPalmer1994* will produce the same result since only two synsets
        /// are available.</param>
        /// <param name="relations">Synset relations to follow when computing similarity (pass null for all relations)</param>
        /// <returns>Similarity</returns>
        public float GetSimilarity(SynSet synset1, SynSet synset2, Strategy strategy, params WordNetEngine.SynSetRelation[] relations)
        {
            if (relations == null)
                relations = Enum.GetValues(typeof(WordNetEngine.SynSetRelation)).Cast<WordNetEngine.SynSetRelation>().ToArray();

            float similarity = 0;

            if (strategy.ToString().StartsWith("WuPalmer1994"))
            {
                // get the LCS along the similarity relations
                SynSet lcs = synset1.GetClosestMutuallyReachableSynset(synset2, relations);
                if (lcs == null)
                    similarity = 0;
                else
                {
                    // get depth of synsets
                    int lcsDepth = lcs.GetDepth(relations) + 1;
                    int synset1Depth = synset1.GetShortestPathTo(lcs, relations).Count - 1 + lcsDepth;
                    int synset2Depth = synset2.GetShortestPathTo(lcs, relations).Count - 1 + lcsDepth;

                    // get similarity
                    similarity = 2 * lcsDepth / (float)(synset1Depth + synset2Depth);
                }
            }
            else
                throw new NotImplementedException("Unrecognized strategy");

            if (similarity < 0 || similarity > 1)
                throw new Exception("Invalid similarity");
            
            return similarity;
        }
    }
}
