
int emprestimosAtivos = 2;
int limiteEmprestimos = 3;
bool cadastroValido = false;

int exemplaresDisponiveis = 1;
int exemplaresEmprestados = 2;
bool exemplarDanificado = false;

int prazoDias = 7;
int diasDevolucao = 0;
double multaPorDia = 2.50;

// 1. Validacao de emprestimo
if (cadastroValido == false)
{
    Console.WriteLine("Emprestimo negado: cadastro invalido.");
}
else if (emprestimosAtivos >= limiteEmprestimos)
{
    Console.WriteLine("Emprestimo negado: limite de 3 emprestimos ativos.");
}
else if (exemplarDanificado == true || exemplaresDisponiveis <= 0)
{
    Console.WriteLine("Emprestimo negado: exemplar danificado ou sem exemplar disponivel.");
}
else
{
    emprestimosAtivos = emprestimosAtivos + 1;
    exemplaresDisponiveis = exemplaresDisponiveis - 1;
    exemplaresEmprestados = exemplaresEmprestados + 1;
    Console.WriteLine("Emprestimo feito. Prazo: " + prazoDias + " dias corridos.");
}

// 2. Validacao de reserva
if (cadastroValido == false)
{
    Console.WriteLine("Reserva negada: cadastro invalido.");
}
else if (exemplaresDisponiveis > 0)
{
    Console.WriteLine("Reserva negada: tem exemplar disponivel, pode pegar emprestado.");
}
else if (exemplaresEmprestados <= 0)
{
    Console.WriteLine("Reserva negada: nao tem exemplar emprestado agora.");
}
else
{
    Console.WriteLine("Reserva feita para o livro.");
}

// 3. Devolucao e calculo de multa
if (diasDevolucao > prazoDias)
{
    int diasAtraso = diasDevolucao - prazoDias;
    double valorMulta = diasAtraso * multaPorDia;
    Console.WriteLine("Devolucao com atraso de " + diasAtraso + " dia(s). Multa: R$ " + valorMulta);
}
else
{
    Console.WriteLine("Devolucao no prazo de " + prazoDias + " dias corridos. Sem multa.");
}