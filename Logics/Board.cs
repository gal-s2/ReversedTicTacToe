namespace Logics
{
    using System.Collections.Generic;
    using System;

    public class Board
    {
        private enum eMatrixToken { Initialize, PlayerOne, PlayerTwo}
        private int m_BoardSize;
        private byte[,] m_Matrix;
        private List<Coordinate> m_AvailableSpotsList;
        private Random m_RandomSpotGenerator;

        public Board(int i_BoardSize)
        {
            m_RandomSpotGenerator = new Random();
            m_BoardSize = i_BoardSize;
            m_Matrix = new byte[i_BoardSize, i_BoardSize];
            m_AvailableSpotsList = new List<Coordinate>();

            ClearBoard();
        }

        public byte[,] Matrix
        {
            get 
            {
                return m_Matrix;
            }
        }

        public void ClearBoard()
        {
            m_AvailableSpotsList.Clear();

            for (int i = 0; i < m_BoardSize; i++)
            {
                for (int j = 0; j < m_BoardSize; j++)
                {
                    m_AvailableSpotsList.Add(new Coordinate((byte)(i), (byte)(j)));
                    m_Matrix[i,j] = 0;
                }
            }
        }

        public Coordinate GetCoordinateSpotFromAvailable()
        {
            int randomIndex = m_RandomSpotGenerator.Next(0, m_AvailableSpotsList.Count - 1);
            Coordinate spotFromRandom = m_AvailableSpotsList[randomIndex];
            return spotFromRandom;
        }

        public bool IsSpotAvailable(Coordinate i_Coordinate)
        {
            return m_Matrix[i_Coordinate.x, i_Coordinate.y] == 0;
        }

        public void AssignCharacterToCoordinate(Coordinate i_Coordinate, byte i_TokenToPutInSpot)
        {
            m_Matrix[i_Coordinate.x, i_Coordinate.y] = i_TokenToPutInSpot;
            m_AvailableSpotsList.Remove(i_Coordinate);
        }

        public bool CheckAllPossibleRoutesForWin(byte i_coordinateX, byte i_coordinateY, byte i_PlayerToken)
        {
            bool rowResult = true;
            bool columnResult = true;
            bool diagonalResultTopDown = true;
            bool diagonalResultDownTop = true;
           
            for (int i = 0; i < m_BoardSize; i++)
            {
                if (m_Matrix[i_coordinateX, i] != i_PlayerToken)
                {
                    rowResult = false;
                }

                if (m_Matrix[i, i_coordinateY] != i_PlayerToken)
                {
                    columnResult = false;
                }

                if (m_Matrix[i, i] != i_PlayerToken)
                {
                    diagonalResultTopDown = false;
                }

                if (m_Matrix[i, m_BoardSize - i - 1] != i_PlayerToken)
                {
                    diagonalResultDownTop = false;
                }
            }

            return (rowResult || columnResult || diagonalResultTopDown || diagonalResultDownTop);
        }

        public bool CheckIfBoardIsFull()
        {
            return m_AvailableSpotsList.Count == 0;
        }
    }
}