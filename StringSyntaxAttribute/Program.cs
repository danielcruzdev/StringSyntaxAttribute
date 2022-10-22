using System.Diagnostics.CodeAnalysis;

TestRegex(@"^a\d+|b\w*");
TestDateTime(DateTime.Now, "dd/MM/yyyy");
TestJson("""
    [
        {
            "Name": "Daniel",
            "Age": 24
        },
        {
           "Name": "Maria",
           "Age": 62
        }
    ]
    """);

string TestJson([StringSyntax(StringSyntaxAttribute.Json)] string json) => json;

string TestDateTime(DateTime datetime, [StringSyntax(StringSyntaxAttribute.DateTimeFormat)] string format) => datetime.ToString(format);

string TestRegex([StringSyntax(StringSyntaxAttribute.Regex)] string regex) => regex;
