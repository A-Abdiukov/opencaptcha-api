namespace Captcha.Core.Models;

public class CaptchaRequest
{
    public required string Text { get; init; }
    public int? Width { get; init; }
    public int? Height { get; init; }
    public CaptchaDifficulty? Difficulty { get; init; }
}
