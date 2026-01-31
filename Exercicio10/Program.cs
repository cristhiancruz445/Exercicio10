namespace Exercicio10
{
    class Program
    {
        public static void Main(string[] args)
        {
            string[] horas = Console.ReadLine().Split(' ');
            int horaInicio = int.Parse(horas[0]);
            int horaFim = int.Parse(horas[1]);

            if(horaInicio > horaFim)
            {
                horaFim += 24;
                int duracao = horaFim - horaInicio;
                Console.WriteLine($"O JOGO DUROU {duracao} HORAS");
            }
            else if(horaInicio == horaFim)
            {
                Console.WriteLine("O JOGO DUROU 24 HORAS");
            }
            else
            {
                int duracao = horaFim - horaInicio;
                Console.WriteLine($"O JOGO DUROU {duracao} HORAS");
            }
        }
    }
}