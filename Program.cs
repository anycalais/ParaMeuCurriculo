
		Console.Clear();
		
		double primeira_nota, // declarar as notas e a media
		       segunda_nota,
		       terceira_nota,
		       quarta_nota,
		       media;
		
		Console.WriteLine("Informar a primeira nota: "); //Obter a primeira nota
		primeira_nota = Convert.ToDouble(Console.ReadLine());
		
		Console.WriteLine("Informar a segunda nota: "); //Obter a segunda nota
		segunda_nota = Convert.ToDouble(Console.ReadLine());
		
		Console.WriteLine("Informar a terceira nota: "); //Obter a terceira nota
		terceira_nota = Convert.ToDouble(Console.ReadLine());
		
		Console.WriteLine("Informar a quarta nota: "); //Obter a quarta nota
		quarta_nota = Convert.ToDouble(Console.ReadLine());
		
		media = (primeira_nota + segunda_nota + terceira_nota + quarta_nota) / 4.0; //Somar todos e falar o resultado da media
		Console.WriteLine("A media é: " + media ); //escrever qual valor da media
		
		if (media >=60) //Se a media for menor ou igual 60 sera aprovado
		{
			Console.WriteLine("Aprovado");
		}
		
		else if (media >=40) //Se a media for menor o igual a 40 recuperação
		{
			Console.WriteLine("Recuperação");
		}
		
		else //Se não a pessoa esta reprovado
		{
			Console.WriteLine("Reprovado");
		}