using System.Drawing;

Console.WriteLine(@"Դ���ַ: https://gitee.com/zxzyjs/SimpleAdmin");
Console.WriteLine(@"��ʾ��ַ: http://153.101.199.83:12802/login");
Console.WriteLine(@"QQ:531035580");
Console.WriteLine("û�л�����ڣ�ֻ�м򵥡��ȶ�������Ч");
Colorful.Console.WriteAsciiAlternating("SimpleAdmin", new Colorful.FrequencyBasedColorAlternator(3, Color.Yellow, Color.GreenYellow));
Serve.Run(RunOptions.Default.ConfigureBuilder(builder =>
{
    builder.WebHost.UseUrls(builder.Configuration["AppSettings:Urls"]);
}));