// Напиши функцію на C#, яка:
// 1. Генерує рандомний пароль довжиною 12 символів
// 2. Перевіряє верхній регістр, цифри, символи
// 3. Повертає оцінку 0-100
// 4. Якщо < 70 - генерує новий

class Program
{
static string GeneratePassword()
{
    const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()";
    var random = new Random();
    return new string(Enumerable.Repeat(chars, 12)
        .Select(s => s[random.Next(s.Length)]).ToArray());
}

static int EvaluatePassword(string password)
{
    int score = 0;

    if (password.Any(char.IsUpper)) score += 25; // Верхній регістр
    if (password.Any(char.IsDigit)) score += 25; // Цифри
    if (password.Any(ch => !char.IsLetterOrDigit(ch))) score += 25; // Символи
    if (password.Length >= 12) score += 25; // Довжина

    return score;
}

static string GetStrongPassword()
{
    string password;
    int score;

    do
    {
        password = GeneratePassword();
        score = EvaluatePassword(password);
    } while (score < 70);

    return password;
}

static void Main()
{
    string strongPassword = GetStrongPassword();
    Console.WriteLine($"Згенерований сильний пароль: {strongPassword}");
}
}