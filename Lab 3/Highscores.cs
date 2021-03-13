using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_3
{
    class HighScores
    {
        private string mName;
        private int mScore;

        public string Name
        {
            get { return mName;  }
        }

        public int Score
        {
            get { return mScore; }
        }

        public HighScores(string pName, int pScore)
        {
            mName = pName;
            mScore = pScore;
        }
        
    }
}
