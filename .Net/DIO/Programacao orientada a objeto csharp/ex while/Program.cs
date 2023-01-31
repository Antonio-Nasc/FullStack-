int tabuada = 10;
int contador = 0;
while(contador <= 10){
    Console.WriteLine($"{contador + 1}º: {tabuada * contador}");
    contador++;
    if(contador == 5){
        break;
    }
}

int diminuir = 10;
while(diminuir >= 0){
    Console.WriteLine(diminuir);
    diminuir--;
}