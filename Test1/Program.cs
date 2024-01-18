// See https://aka.ms/new-console-template for more information

using BenchmarkDotNet.Running;
using Test1;

string CheckPal(string palName)
{

    string rev=palName.ToCharArray().Reverse().ToString();
    string newString = rev + palName;
    char[] chars = newString.ToCharArray();
    char[] chars2 = Array.Empty<char>();
    chars=chars.Reverse().ToArray();
    if (chars.ToString() == chars2.ToString())
        return "Palindrome";
    return "Not Palendrome";
}
void FIndSecondLarg(int[] arr)
{

    Array.Sort(arr, (x, y) => y.CompareTo(x));
 //   List<int> list = new List<int>();   
	//for (int i = 0; i < arr.Length; i++)
	//{
 //       for (int j = 1; j < arr.Length; j++)
 //       {
 //           if (arr[i] > arr[j])
 //           {
 //               list.Add(arr[i]);
 //           }
 //       }
        
 //   }
    Console.WriteLine(arr[1]);
   // return list[1];
}


 static bool robot(string moves )
{
    int x=0, y=0;

    foreach (char item in moves)
    {
        switch (item)
        {
            case 'U': y++; break;
            case 'D': y--;break;
            case 'L':x--; break;
            case 'R':x++; break;
        }
    }
    Console.WriteLine(x == 0 && y == 0);
     
     return x == 0 && y==0;

}

static int BinarySearch(int[] array, int target)
{
    int left = 0;
    int right = array.Length - 1;

    while (left <= right)
    {
        int mid = left + (right - left) / 2;

        // Check if the target is present at the middle
        if (array[mid] == target)
            return mid;

        // If the target is greater, ignore the left half
        if (array[mid] < target)
            left = mid + 1;

        // If the target is smaller, ignore the right half
        else
            right = mid - 1;
    }

    // If the target is not present in the array
    return -1;
}
CheckPal("dhfusidhfusid");
int[] srr = { 1, 2, 5, 8, 89 };

int[] arr = { 7,5,1000,738,6666,79879,25346,1000 };
Console.WriteLine(BinarySearchPrograms.SealingOfTarget(srr, 7));
Console.WriteLine(BinarySearchPrograms.FlooreOfTarget(srr, 7));
FIndSecondLarg(srr);

Console.ReadKey();

