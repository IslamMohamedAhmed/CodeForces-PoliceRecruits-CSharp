using static System.Console;
using static System.Convert;
using static System.Math;



int n,crimes = 0,recruits = 0;

n = ToInt32(ReadLine());
string str = ReadLine();
var arr = str.Split(" ");

for (int i = 0; i < n; i++)
{
    if (ToInt32(arr[i]) == -1)
    {
        if(recruits > 0)
        {
            recruits--;
        }
        else
        {
            crimes++;
        }
    }
    else
    {
        recruits += ToInt32(arr[i]);
    }
}

WriteLine(crimes);
