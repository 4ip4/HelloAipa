Console.Write("名前を入力してください。");
string? strName = Console.ReadLine();
if (string.IsNullOrEmpty(strName))
{
    Console.WriteLine("入力が無効です");
    return; // ここで終了
}

Console.WriteLine($"こんにちわ！{strName}さん！");

Console.Write("数字1を入力：");
string? strInput1 = Console.ReadLine();
if (!int.TryParse(strInput1, out int iNum1))
{
    Console.WriteLine("数字の入力ではありません");
    return;
}

Console.Write("数字2を入力：");
string? strInput2 = Console.ReadLine();
if (!int.TryParse(strInput2, out int iNum2))
{
    Console.WriteLine("数字の入力ではありません");
    return;
}

Console.WriteLine($"足し算: {iNum1 + iNum2}");
Console.WriteLine($"引き算: {iNum1 - iNum2}");
Console.WriteLine($"掛け算: {iNum1 * iNum2}");
Console.WriteLine($"割り算: {iNum1 / iNum2}");