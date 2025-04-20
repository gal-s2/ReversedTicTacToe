namespace Logics
{
    public class Player
    {
        private uint m_CurrentScore;
        private readonly byte r_PlayerToken;
        private readonly bool r_IsBot;
        private string m_Name;

        public Player(byte i_PlayerToken, bool i_IsBot)
        {
            m_CurrentScore = 0;
            r_PlayerToken = i_PlayerToken;
            r_IsBot = i_IsBot;
        }

        public string Name
        {
            get { return m_Name; }
            set { m_Name = value; }
        }

        public bool IsBot
        {
            get { return r_IsBot; }
        }

        public byte PlayerToken
        {
            get { return r_PlayerToken; } 
        }

        public uint CurrentScore
        {
            get { return m_CurrentScore; } 
            set { m_CurrentScore = value; }
        }
    }
}