int count = 0;
int distance = 10000; // Distance between friends
int ffs = 1; //FirstFriendSpeed
int sfs = 2; //SecondFriendSpeed
int ds = 5; //DogSpeed
int fr = 2; //Which friend dog is running to
int time = 0;

while (distance > 10)
{
        if(fr == 1)
        {
        time = distance/(ffs+ds);
        fr = 2;
        }
        else
        {
        time = distance/(sfs+ds);
        fr = 1;
        }
    distance = distance - (ffs+sfs)*time;
    count++;
}

Console.Write("Dog will run - ");
Console.WriteLine(count);

