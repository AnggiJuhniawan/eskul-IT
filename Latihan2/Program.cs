// Buatkan tampilan dengan ada Console.Write dan Console.WriteLine
// OUTPUT :
// =======================
// Nama : Anggi
// Kelas : X RPL 2
// Sekolah : Wijaya Kusuma
// =======================
// Console.Write("Hello, ANggi");
// Console.WriteLine("====");

// Variable
// string nama = "Sinta";
// string jurusan = "RPL";
// int umur = 16;
// bool isActive = true;

// Console.WriteLine(nama); cara 1
// Console.WriteLine("Jurusanku : " + jurusan); cara 2
// Console.WriteLine($"Namaku adalah {nama}");
// Console.WriteLine($"Jurusan : {jurusan}");
// Console.WriteLine($"Umur : {umur}");
// Console.WriteLine($"Siswa aktif ga : {isActive}");

// Variabel dinamis
Console.Write("Masukkan Nama : ");
string name = Console.ReadLine();

Console.Write("Umur : ");
int umur = int.Parse(Console.ReadLine());

Console.WriteLine($"Nama : {name}");
Console.WriteLine($"Umur : {umur}");







OUTPUT :

// ==== ISI DATA ====
// Masukkan Nama : 
// Masukkan Kelas :
// Masukkan Umur :
// Masukkan Sekolah : 
// ===== BIODATA SISWA =====
// Nama    : Andi
// Kelas   : X RPL 1
// Umur : 18
// Sekolah : Sekolah Wijaya Kusuma