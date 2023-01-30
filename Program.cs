using System;

class Program {
  public static void Main (string[] args) {
    int[,] board = new int[3,3] {{1,0,0}, {1,0,0}, {1,0,0}};
    iterate(board);
    
    
    //p1 = x
    //p2 = o
    //cant change values if already present
    //iterate after every choice
  }


  public static string iterate(int[,] board){

    double lengthOfRow = Math.Sqrt(board.Length);
    for (int i = 0; i < lengthOfRow; i++) {
      for (int j = 0; j < lengthOfRow; j++) {
        if (board[i,j] == 1) {
          check(board, i, j, 1);
        } else if (board[i, j] == 2) {
          check(board, i, j, 2);
        }
      }
    }
    return "0";
  }

  static int check(int[,] board, int pos_i, int pos_j, int num_to_check ) 
  {
  int i = pos_i;
  int j = pos_j;
    
  //all pos around it, 
  //all direction, and their inverses
  //when you move the pointer in a dir, remove the inverse from the temp list
      
    double count = Math.Sqrt(board.Length) - 1;
      //array of dir
    (int dir_i, int dir_j) [] dir = new [] {
    (-1, 0), (1, 0), (0, -1), (0, 1), (-1, -1), (1, 1), 
    (1,-1), (-1, 1)
    };

    (int inv_i, int inv_j) [] inv_dir = new [] {
    (1, 0), (-1, 0), (0, 1), (0, -1), (1, 1), (-1, -1), 
    (-1, 1), (1, -1) 
    };

    bool Valid_dir = false;
      
    for (int h = 0; h < 7; h++) {

      if (((i + dir[h].Item1) < 3) && ((i + dir[h].Item1) > -1)) {
        if (((j + dir[h].Item2) < 3) && ((j + dir[h].Item2) > -1)) {
          Valid_dir = true;
          Console.WriteLine(h);
          Console.WriteLine(Valid_dir);
        }
      } else {
        Valid_dir = false;
      }


      if (Valid_dir) {
        Console.WriteLine(h);
        if (board[(i + dir[h].Item1), (j + dir[h].Item2)] ==  num_to_check) {
          Console.WriteLine("workds");
        }
      }
        
          //creat the temp array
        /*(int dir_i, int dir_j) [] temp_dir = dir;
        for (i = h-1; i < 6; i++) {
          temp_dir[i] = temp_dir[i + 1];
        }*/
  }
    return 0;
    }


    
}