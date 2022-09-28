// See https://aka.ms/new-console-template for more information
List<string> g = new List<string>(9);
g.Add("1");
g.Add("2");
g.Add("3");
g.Add("4");
g.Add("5");
g.Add("6");
g.Add("7");
g.Add("8");
g.Add("9");

bool game = true;
bool turn1 = false;
bool turn2 = false;
string Selected_Space = "0";

do {
    board(g);
    player1(turn1, Selected_Space, turn2, g);
    game = win_check(g, game);
    board(g);
    if (game == false)
    {
        break;
    }
    board(g);
    player2(turn1, Selected_Space, turn2, g);
    game = win_check2(g, game);
    board(g);
     if (game == false)
    {
        break;
    }
}while(game == true);


static void board(List<string> g)
    {
        string gap = "-+-+-";
        Console.WriteLine($"{g[0]}|{g[1]}|{g[2]}\n{gap}\n{g[3]}|{g[4]}|{g[5]}\n{gap}\n{g[6]}|{g[7]}|{g[8]}");
    }

    

static void player1(bool turn1, string Selected_Space, bool turn2, List<string>g)
    {
        turn1 = true;

        Console.WriteLine("Player 1 - Select a space");
        Selected_Space = Console.ReadLine();
        markspace(Selected_Space, turn1, turn2, g);

        turn1 = false;
    }


static void player2(bool turn1, string Selected_Space, bool turn2, List<string>g)
    {
        turn2 = true;

        Console.WriteLine("Player 2 - Select a space");
        Selected_Space = Console.ReadLine();

        markspace(Selected_Space, turn1, turn2, g);

        turn2 = false;
    }



static string markspace (string Selected_Space, bool turn1, bool turn2, List<string>g)
    {
        string mark;
        

        if (turn1 == true)
            {
                mark = "x";
            }
        else
            {
                mark = "o";
            }
        Update_List(Selected_Space,mark,g);
        return mark;
        


    }

static List<string> Update_List (string Selected_Space, string mark, List<string>g)
    {   
        int Space_marked =0;
        int Selected_spaceint = int.Parse(Selected_Space);

            Space_marked = Selected_spaceint - 1;
                g[Space_marked] = mark;
        return g;
    }

static bool win_check (List<string> g, bool game )
    {
        if (
                g[0]=="x" &&  // x|x|x
                g[1]=="x" &&  //
                g[2]=="x")
        {                    //
                win1(game);
                game = false;
        }
          else if (
                g[3]=="x" &&  // 
                g[4]=="x" &&  //
                g[5]=="x")
        {                    //
                win1(game);
                game = false;
        }
          else if (
                g[6]=="x" &&  // x|x|x
                g[7]=="x" &&  //
                g[8]=="x")
        {                    //
                win1(game);
                game = false;
        }
    else if (
                g[0]=="x" &&  // x|x|x
                g[3]=="x" &&  //
                g[6]=="x")
        {                    //
                win1(game);
                game = false;
        }

    else if (
                g[1]=="x" &&  // x|x|x
                g[4]=="x" &&  //
                g[7]=="x")
        {                    //
                win1(game);
                game = false;
        }
    else if (
                g[2]=="x" &&  // x|x|x
                g[5]=="x" &&  //
                g[8]=="x")
        {                    //
                win1(game);
                game = false;
        }
    else if (
                g[0]=="x" &&  // x|x|x
                g[4]=="x" &&  //
                g[8]=="x")
        {                    //
                win1(game);
                game = false;
        }
    else if (
                g[2]=="x" &&  // x|x|x
                g[4]=="x" &&  //
                g[6]=="x")
        {                    //
                win1(game);
                game = false;
        }

        return game;

    }

static bool win_check2 (List<string> g, bool game )
    {
             if (
                g[0]=="o" &&  // x|x|x
                g[1]=="o" &&  //
                g[2]=="o")
        {                    //
                win2(game);
                game = false;
        }
          else if (
                g[3]=="o" &&  // x|x|x
                g[4]=="o" &&  //
                g[5]=="o")
        {                    //
                win2(game);
        }
          else if (
                g[6]=="o" &&  // x|x|x
                g[7]=="o" &&  //
                g[8]=="o")
        {                    //
                win2(game);
                game = false;
        }
         else if (
                g[0]=="o" &&  // x|x|x
                g[3]=="o" &&  //
                g[6]=="o")
        {                    //
                win2(game);
                game = false;
        }

          else if (
                g[1]=="o" &&  // x|x|x
                g[4]=="o" &&  //
                g[7]=="o")
        {                    //
                win2(game);
                game = false;
        }
          else if (
                g[2]=="o" &&  // x|x|x
                g[5]=="o" &&  //
                g[8]=="o")
        {                    //
                win2(game);
                game = false;
        }
  else if (
                g[0]=="o" &&  // x|x|x
                g[4]=="o" &&  //
                g[8]=="o")
        {                    //
                win2(game);
                game = false;
        }
  else if (
                g[2]=="o" &&  // x|x|x
                g[4]=="o" &&  //
                g[6]=="o")
        {                    //
                win2(game);
                game = false;
        }

        return game;
}

static void win1(bool game)
{
    Console.WriteLine("Congradulations Player 1, you won!");
}

static void win2(bool game)
{
    Console.WriteLine("Congradulations Player 2, you won!");
}