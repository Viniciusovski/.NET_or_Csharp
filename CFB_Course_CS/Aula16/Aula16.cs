using System;

class Aula16{

    static void Main(){
        
        int tempo=0;
        char escolha= '';

        inicio: // isso é um label

        Console.Clear();

        Console.WriteLine("Belo Horizonte/MG a Vitória/ES")
        Console.WriteLine("Escolha o transporte: [a]=Avião | [c]Carro | [o]Ônibus ");
        escolha=char.Parse(Console.ReadLine());

        switch(escolha){
            case 'a':
            case 'A':
                tempo=50;
                break;
            case 'c':
            case 'C':
                tempo=480
                break;
            case 'o':
            case 'O':
                tempo=660;
                break;
            default:
                tempo=-1;
                break;

        }

        if(tempo <0){
            Console.WriteLine("Transporte não reconhecido");
        }else{
            Console.WriteLine("Para o transporte escolhido o tempo é: {0} minutos", tempo);
        }

        Console.Write("Calcular outro transporte? [s/n]");
        escolha=char.Parse(Console.ReadLine());

        if(escolha=='s' || escolha=='S'){
            goto inicio; // Volta o programa para o ponto da declaração da label inicio
        }else{
            Console.Clear();
            Console.WriteLine("Fim do Programa")
        }

    }
}