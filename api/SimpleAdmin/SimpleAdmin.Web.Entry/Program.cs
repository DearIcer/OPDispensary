// SimpleAdmin ���� Apache License Version 2.0 Э�鷢������������ҵ��Ŀ���������������²�������:
// 1.�벻Ҫɾ�����޸ĸ�Ŀ¼�µ�LICENSE�ļ���
// 2.�벻Ҫɾ�����޸�SimpleAdminԴ��ͷ���İ�Ȩ������
// 3.�ַ�Դ��ʱ����ע��������� https://gitee.com/zxzyjs/SimpleAdmin
// 4.���ڱ��������Ʒ����ֻ��ʹ�� SimpleAdmin ��Ϊ��̨���񣬳���������������Ҳ�������ηַ���Դ��
// 5.�벻�ý������Ӧ����Σ�����Ұ�ȫ���������������Ϊ���������κ���ʽ���ڷǷ�ΪĿ�ĵ���Ϊ��Ҫɾ�����޸�����������
// 6.�κλ��ڱ������������һ�з��ɾ��׺����Σ�������˾�޹ء�

Console.WriteLine(@"Դ���ַ: https://gitee.com/zxzyjs/SimpleAdmin");
Console.WriteLine(@"��ʾ��ַ: http://153.101.199.83:12802/login");
Console.WriteLine(@"QQ:531035580");
Console.WriteLine("�ܾ�ʺɽ,ֻ����ʵ,��.NET ��������");
Serve.Run(RunOptions.Default.ConfigureBuilder(builder =>
{
    builder.WebHost.UseUrls(builder.Configuration["AppSettings:Urls"]);
}));
