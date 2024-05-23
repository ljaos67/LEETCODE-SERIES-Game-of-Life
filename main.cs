public class Solution {
    public void GameOfLife(int[][] board) 
    {
        int rows = board.Length;
        int cols = board[0].Length;
        int[][] state = new int[rows][];
        for (int i = 0; i < rows; i++) {
            state[i] = new int[cols]; // Initialize each row with 'm' columns.
        }

        int liveCount = 0;
        for(int i = 0; i < board.Length; i++)
        {
            for(int j = 0; j < board[0].Length; j++)
            {
                state[i][j] = board[i][j];
                // top left
                if((j - 1) >= 0 && (i - 1) >= 0)
                {
                    if(board[i-1][j-1] == 1)
                    {
                        liveCount++;
                    }
                }
                // top top
                if((i - 1) >= 0)
                {
                    if(board[i-1][j] == 1)
                    {
                        liveCount++;
                    }
                }
                // top right
                if((j + 1) < board[0].Length && (i - 1) >= 0)
                {
                    if(board[i-1][j+1] == 1)
                    {
                        liveCount++;
                    }
                }
                // left
                if((j - 1) >= 0)
                {
                    if(board[i][j-1] == 1)
                    {
                        liveCount++;
                    }
                }
                // right
                if((j + 1) < board[0].Length)
                {
                    if(board[i][j+1] == 1)
                    {
                        liveCount++;
                    }
                }
                // bot left
                if((j - 1) >= 0  && (i + 1) < board.Length)
                {
                    if(board[(i + 1)][(j - 1)] == 1)
                    {
                        liveCount++;
                    }
                }
                // bot mid
                if((i + 1) < board.Length)
                {
                    if(board[(i + 1)][j] == 1)
                    {
                        liveCount++;
                    }
                }                                
                // bot right
                if((j + 1) < board[0].Length  && (i + 1) < board.Length)
                {
                    if(board[(i + 1)][(j + 1)] == 1)
                    {
                        liveCount++;
                    }
                }
                // rules
                if(liveCount < 2)
                {
                    state[i][j] = 0;
                }
                else if(liveCount == 3)
                {
                    state[i][j] = 1;
                }
                else if(liveCount > 3)
                {
                    state[i][j] = 0;
                }
                liveCount = 0;
            }
        }
        for(int i = 0; i < board.Length; i++)
        {
            for(int j = 0; j < board[0].Length; j++)
            {
                board[i][j] = state[i][j];
            }
        }    
    }
}
