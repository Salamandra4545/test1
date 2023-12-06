string Func(int lastPosition)
{


    bool X, Y, Z;

    Console.WriteLine("X  Y  Z  отрицание (X конъюнкция Y) дизъюнкция (X конъюнкция отрицание Z)  X конъюнкция отрицание(отрицание Y дизъюнкция Z) дизъюнкция Y");

    for (int i = 0; i <= 1; i++)
    {
        X = Convert.ToBoolean(i);
        for (int j = 0; j <= 1; j++)
        {
            Y = Convert.ToBoolean(j);
            for (int k = 0; k <= 1; k++)
            {
                Z = Convert.ToBoolean(k);
                bool problem1 = !(X && Y) || (X && !Z);
                bool problem2 = X && !(!Y && Z) || Y;
                Console.WriteLine($"{X}  {Y}  {Z}      {problem1}       {problem2}");
            }
        }

    }
    if (lastPosition == 1) { return "1 число"; }
    else if (lastPosition == 2) return "2 число";
    else return "some";
}

string answer = Func(1);
Console.WriteLine(answer);