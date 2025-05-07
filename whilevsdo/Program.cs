Console.WriteLine("lütfen bir max-değer  belirtin ");
int value = int.Parse(Console.ReadLine());
int limit =1;
while (limit <=value  )
{

    Console.WriteLine($"{limit} ben bir patikalıyım");
    limit++;
}

//while döngüsü koşulu başta kontrol ettiği için hatalı girişlerde hiç çalışmaz ve daha güvenlidir. do...while en az bir kez çalıştığı için geçersiz girişlerde bile çıktı verir, bu da istenmeyen durumlara yol açabilir.

Console.WriteLine("lütfen bir max-değer belirtin");
int numberr = int.Parse(Console.ReadLine());

int sinir = 1;
do
{

    Console.WriteLine($"{sinir} ben bir patikalıyım");


    sinir++;

} while (sinir <= numberr);
