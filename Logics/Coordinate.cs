namespace Logics
{
    public struct Coordinate
    {
        private byte m_X;
        private byte m_Y;

        public Coordinate(byte i_valueX, byte i_valueY)
        {
            m_X = i_valueX;
            m_Y = i_valueY;
        }

        public byte x
        {
            get
            {
                return m_X;
            }
        }

        public byte y
        {
            get
            {
                return m_Y;
            }
        }
    }
}