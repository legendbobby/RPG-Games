===SM_2
Setelah Mengetahui Prefix dan Subnet Mask. Sekarang kita akan mempelajari cara Subnetting atau membagi Jaringan.
Subnetting atau membagi jaringan setelah melihat materi yang sudah dicari dan dibaca, ada beberpa Proses yang harus dikerjakan.
Pada Materi tersebut adalah Cara membagi jaringan sesuai berapa banyak jaringan yang akan dibagi. Sehingga jumlah host setiap jaringan akan sama.
Maksudnya jika ada suatu jaringan dengan Subnet Mask 255.255.255.0 atau /24 akan dibagi 2 jaringan yang berbeda. Maka Jumlah Host yang asalnya 1 jaringan 256 Host. Menjadi 2 jaringan berbeda dengan masing masing 128 Host.
Subnet Mask nya pun ikut berganti seperti dalam materi. Menjadi 255.255.255.128 atau /25. Hal ini dapat dilakukan dengan melakukan perhitungan di subnet mask yang berbentuk biner.
Subnet Mask 255.255.255.0 atau /24 ubah ke Biner menjadi 11111111.111111111.11111111.00000000, Karena akan dibagi menjadi 2 Jaringan. Maka carilah nilai x dari 2^x >= 2, angkat 2 adalah jaringan yang akan dibagi, sedangkan 2^x dalah rumus nya.
Maka 2^x >= 2, adalah X = 1, X=1 adalah Jumlah angka 1 yang akan ditambahkan ke Subnet Mask Biner, sehingga 11111111.111111111.11111111.00000000 atau /24 ditambahlah angka 1 berjumlah 1 jadi ke dalam biner nya menjadi, 111111111.111111111.111111111.10000000 atau /255
Sampai disini kita bisa tau jumlah host per Subnet nya berapa yakni 2^7 adalah 128 (Ingat! 7 diambil dari jumlah angka 0 dari subnet mask biner yang baru)
Sisanya untuk mencari Network Address (NA), IP Range dan Broadcast. Bisa liat kembali di Materi (Inventory)
Apakah dapat dimengerti?
{
-SM==4:
    + [Iya, Sudah Mengerti]
        ->MISI_2_E
    + [Tolong Ulangi]
        Baik saya Ulangi!
        -> SM_2
-else:
->COBA_1

}
    
===MISI_2_E
Sekarang Coba Selesaikan Permasalahan Subnetting menggunakan metode Polya. Seperti sebelumnya.
Informasi Problem Solving bisa cari di Perpustakaan.
~SM=5
-> COBA_1