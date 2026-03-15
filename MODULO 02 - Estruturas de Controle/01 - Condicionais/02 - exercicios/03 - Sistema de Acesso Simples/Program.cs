Console.WriteLine(@"Sistema de Acesso Simples
1 - Administrador
2 - Gerente
3 - Funcionário
4 - Visitante
0 - Sair");
int tipoPerfil = Convert.ToInt16(Console.ReadLine());
switch(tipoPerfil)
{
    case 1: Console.WriteLine("**Administrado**: Bem-vindo, Administrador. Você tem acesso total Acesso total ao sistema");break;
    case 2: Console.WriteLine("**Gerente**: Bem-vindo Gerete, você tem acesso a relatórios e cadastros do sistema");break;
    case 3: Console.WriteLine("**Funcionário**: Bem-vindo Funcionário, você tem aaesso básico ás funcionalidade do sistema" );break;
    case 4: Console.WriteLine("**Visitante**: Bem-vindo Visitante, você te acesso somente á vissualização de informacões públicas");break;
    case 0: Console.WriteLine("Saindo do sistema...");return;
    default: Console.WriteLine("Perfil invalido");break;

}
