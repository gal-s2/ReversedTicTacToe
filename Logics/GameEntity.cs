namespace Logics
{
    public class GameEntity
    {
        private Board m_GameBoard;
        private Player m_PlayerOne;
        private Player m_PlayerTwo;
        private byte m_CurrentTurn;
        private byte m_SizeOfBoard;
        private const byte k_PlayerOneToken = 1;
        private const byte k_PlayerTwoToken = 2;

        public GameEntity(byte i_SizeOfBoard, byte i_NumberOfPlayers)
        {
            m_SizeOfBoard = i_SizeOfBoard;
            m_GameBoard = new Board(m_SizeOfBoard);
            m_CurrentTurn = k_PlayerOneToken;
            m_PlayerOne = new Player(k_PlayerOneToken, false);
            m_PlayerTwo = new Player(k_PlayerTwoToken, i_NumberOfPlayers == 1);
        }

        public byte PlayerOneToken
        {
            get
            {
                return k_PlayerOneToken;
            }
        }

        public byte PlayerTwoToken
        {
            get
            {
                return k_PlayerTwoToken;
            }
        }

        public byte SizeOfBoard
        {
            get
            {
                return m_SizeOfBoard;
            }
        }

        public byte CurrentTurn
        {
            get
            {
                return m_CurrentTurn;
            }

            set
            {
                m_CurrentTurn = value;
            }
        }

        public Board GameBoard
        {
            get
            {
                return m_GameBoard;
            }
        }

        public Player PlayerOne
        {
            get
            {
                return m_PlayerOne;
            }
        }

        public Player PlayerTwo
        {
            get
            {
                return m_PlayerTwo;
            }
        }

        public Player CurrentPlayer
        {
            get
            {
                if(m_CurrentTurn == k_PlayerOneToken)
                {
                    return PlayerOne;
                }
                else
                {
                    return PlayerTwo;
                }
            }
        }

        public void SwitchTurn()
        {
            if(m_CurrentTurn == k_PlayerOneToken)
            {
                m_CurrentTurn = k_PlayerTwoToken;
            }
            else
            {
                m_CurrentTurn = k_PlayerOneToken;
            }
        }

        public void ResetGame()
        {
            m_CurrentTurn = k_PlayerOneToken;
            m_GameBoard.ClearBoard();
        }

        public bool AddTokenToMatrix(Coordinate i_Coordinate, byte i_PlayerToken)
        {
            bool result = m_GameBoard.IsSpotAvailable(i_Coordinate);

            if(result)
            {
                m_GameBoard.AssignCharacterToCoordinate(i_Coordinate, i_PlayerToken);
            }

            return result;
        }

        public Player IsGameEndedWithWinner(Coordinate i_Coordinate, byte i_PlayerToken)
        {
            if(m_GameBoard.CheckAllPossibleRoutesForWin(i_Coordinate.x, i_Coordinate.y, i_PlayerToken))
            {
                return m_CurrentTurn == k_PlayerOneToken ? PlayerTwo : PlayerOne;
            }

            return null;
        }

        public bool IsBoardFull()
        {
            return m_GameBoard.CheckIfBoardIsFull();
        }

        public void AddPointsToWinningPlayer()
        {
            if(m_CurrentTurn == k_PlayerOneToken)
            {
                m_PlayerOne.CurrentScore++;
            }
            else
            {
                m_PlayerTwo.CurrentScore++;
            }
        }
    }
}