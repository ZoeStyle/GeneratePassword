const string characters = $@"A;B;C;D;E;F;G;H;I;J;K;L;M;N;O;P;Q;R;S;T;U;V;W;X;Y;Z;" +
                          $@"a;b;c;d;e;f;g;h;i;j;k;l;m;n;o;p;q;r;s;t;u;v;w;x;y;z;" +
                          $@"0;1;2;3;4;5;6;7;8;9;" +
                          $@"!;@;#;$;%;&;*";

var rand = new Random();

string[] CharactersPassword() =>
    characters.Split(";");

int SizePassword()
{
    Console.WriteLine("Por favor informe o tamanho da senha desejada (somente números)");
    var size = Console.ReadLine();
    int.TryParse(size, out var length);
    return length;
}

void SendPassword(string password)
{
    Console.Clear();
    Console.WriteLine($"Sua nova senha gerada com sucesso: {password}");
    Console.WriteLine($"");
    Console.WriteLine($"");
    Console.WriteLine("deseja gerar uma nova senha ? s/n");

}

void FinallyApp()
{

    Console.WriteLine("Obrigado por utilizar este simulador volte sempre!");

    Console.ReadKey();
}

void InitialApp()
{
    Console.Clear();
    Console.WriteLine("Simulador de senhas");

}

string CreatePassword(string[] charactersPassword, int size)
{
    string newPasword = string.Empty;

    int count = 1;

    while (count <= size)
    {
        var nextRandString = rand.Next(0, CharactersPassword().Count() - 1);
        newPasword += CharactersPassword()[nextRandString];
        count++;
    }

    return newPasword;
}

void HasCOntinue()
{
    if (Console.ReadLine().ToUpper() == "S")
        GeneratePassword();
}

void GeneratePassword()
{
    string[] charactersPassword = CharactersPassword();

    InitialApp();

    var size = 0;
    
    while(size == 0)
        size = SizePassword();
    
    string newPasword = CreatePassword(charactersPassword, size);

    SendPassword(newPasword);

    HasCOntinue();

    FinallyApp();
}

GeneratePassword();
