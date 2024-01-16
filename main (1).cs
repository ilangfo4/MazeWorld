/*
Class: CSE1321
Section: 02#
Term: Spring
Instructor: Ermias Mamo
Name: Isaiah Langford
Assignment#: Assignment5B
*/
using System;

class Program {
  public static void Main (string[] args) {
  string answer = "";
  bool gameOver = false;
  bool win = false;
  int i,j,x=0,y=0;
  Console.WriteLine ("[Maze World]");
  do{
  
  
  string [ , ] grid = {
  {"_","X","_","X","X"},
  {"_","X","_","X","W"},
  {"_","_","_","X","_"},
  {"X","X","_","_","_"},
  {"_","_","_","X","X"}
  };
  grid[x,y] = "O";
  for(i = 0; i < 5; i++){

    for(j = 0; j < 5; j++){
        Console.Write(grid[i,j] + ".");
    }
        Console.WriteLine("");
  }
   
Console.WriteLine("Which direction do you want to move up? ");
    answer = Console.ReadLine();   
    
while(answer != "Right" && answer != "Left" && answer != "Up" && answer != "Down"){
      Console.WriteLine("That’s not a valid direction!");
       Console.WriteLine("Which direction do you want to move up to? ");
    answer = Console.ReadLine();   
    }
  Console.WriteLine("");
  if(answer == "Down"){
    if(answer == "Down" && x==4){
      Console.WriteLine("Out of bounds!");
    }
    else{
      x+=1;
    }
  }
  if(answer == "Right"){
    if(answer == "Right" && y == 4){
      Console.WriteLine("Out of bounds!");
    }
    else{
      y+=1;
    }
  }
  if(answer == "Left"){
    if(answer == "Left" && y == 0){
      Console.WriteLine("Out of bounds!");
    }
    else{
      y-=1;
    }
  }
  if(answer == "Up"){
    if(answer == "Up" && x == 0){
      Console.WriteLine("Out of bounds!");
    }
    else{
      x-=1;
    }
  }
  
  if(grid[x,y] == grid[1,4]){
    win = true;
    break;
  }
  else if(grid [x,y] == grid[0,1] || grid [x,y] == grid[1,1] || grid[x,y] == grid[3,0] || grid[x,y] == grid[3,1] || grid[x,y] == grid[0,3] || grid[x,y] == grid[0,4] || grid[x,y] == grid[1,3] || grid[x,y] == grid[2,3] || grid[x,y] == grid[4,3] || grid[x,y] == grid[4,4]){
    gameOver = true;
    break;
  }
  
  
  }while(gameOver != true || win != true);
    if(win == true){
      Console.WriteLine("You win!");
    }
    else if(gameOver == true){
      Console.WriteLine("You hit a wall – Game Over!");
    }
  }
  public static bool checkValidPosition(int [ , ] arr, int x, int y){
    bool wrongPosition = false;
    if(x < 0 || y < 0)
      wrongPosition = true;
      return wrongPosition;
      
  }
  public static int checkGameStatus(int [ , ] arr, int x, int y){

     if(x == 1 && y == 4)
      return 2; 
    
    if((x == 0 && y == 1) || (x == 1 && y == 1) || (x == 3 && y == 0) || (x == 3 && y == 1) || (x == 0 && y == 3) || (x == 0 && y == 4) || (x == 1 && y == 3) || (x == 2 && y == 3) || (x == 4 && y == 3) || (x == 4 && y == 4))
    return 0; 

   //if((x != 0 && y != 1) && (x != 1 && y != 1) && (x != 3 && y != 0) && (x != 3 && y != 1) && (x != 0 && y != 3) && (x != 0 && y != 4) && (x != 1 && y != 3) && (x != 2 && y != 3) && (x != 4 && y != 3) && (x != 4 && y != 4))
    else
       return 1;
  }
}