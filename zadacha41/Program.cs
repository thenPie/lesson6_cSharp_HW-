Console.Write("Введите пять чисел через пробел: ");

var input = Console.ReadLine();
var space = input.Split(" ");
int num1 = int.Parse(space[0]);
int num2 = int.Parse(space[1]);
int num3 = int.Parse(space[2]);
int num4 = int.Parse(space[3]);
int num5 = int.Parse(space[4]);

int[] nums = {num1, num2, num3, num4, num5};
int plus = 0;

for(int i = 0; i < nums.Length; i++) {
    if(0 < nums[i]) {
        plus++;
    }
}

Console.Write(plus);