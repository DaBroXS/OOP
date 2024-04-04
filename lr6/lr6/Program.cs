string text = "Evade me, Dave!";

int start = 0;
int end = text.Length - 1;

text = text.ToLower();
bool result = false;

while (true)
{
    if (start >= end)
    {
        result = true;
        break;
    }

    char left = text[start];
    char right = text[end];

    if (char.IsLetter(left) is false)
    {
        start++;
        continue;
    }

    if (char.IsLetter(right) is false)
    {
        end--;
        continue;
    }

    if (left == right)
    {
        start++;
        end--;
        continue;
    }
    else
    {
        result = false;
        break;
    }
}

Console.WriteLine(text);
Console.WriteLine(result);