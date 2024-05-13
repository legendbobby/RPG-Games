===prefix
Saat kalian melihat IP Address di komputer atau Gadget kalian kalian sering juga melihat nomor seperti IP Address berdampingan IP Addressnya yakni Subnet Mask dan prefix
Subnet mask bentuknya seperti IP Address, dia punya 4 Oktet dan bisa dikonversi ke biner yang terdiri dari 32 bit, Subnet Mask sendiri adalah sebagai pembagi atau pemecah suatu jaringan. 
Jika kalian tidak melihat subnet mask namum melihat slash atau "/" nomer (contoh /24) itu disebut Prefix. 
Prefix adalah nomer pengganti subnet mask, Prefix biasanya terlihat di belakang IP address itu sendiri sebagai contoh 192.168.88.254 /24.
/24 itu sendiri merupakan banyaknya angka biner. Contoh nya sendiri subnet mask 255.255.255.0 yang biasa kalian lihat, dan jika dikonversi ke biner menjadi 11111111.11111111.11111111.00000000
Jika kalian hitung jumlah total angka 1 nya berjumlah 24 sehingga prefixnya /24, Sebagai contoh lain 255.255.255.192 konversi ke biner menjadi 11111111.11111111.11111111.11000000 dengan prefix nya adalah /26
Dari angka biner Subnet Mask kita juga bisa mengetahui berapa banyak IP Address yang dapat dipakai disuatu jaringan.
Sebagai Contoh sebelumnya /24 dengan Subnet Mask Binernya 11111111.11111111.11111111.00000000. Kita tinggan menghitung dengan Rumus 2^n (2 pangkat n), dimana n adalah jumlah angka 0 dari Subnet Mask Biner.
Setelah Kita hitung bahwa 11111111.11111111.11111111.00000000, memiliki 8 buah jumlah angka 0. Sehingga jika dimasuki rumus 2^n adalah 2^8.
2^8 (2 Pangkat 8) adalah 256 Host atau IP address. 
Tambahan Informasi berhubungan dengan Subnet Mask, Pembagian jaringan diperlukan untuk keamanan jaringan itu sendiri atau mempermudah manajemen jaringan sehingga kita tidak pusing perangkat mana yang terhubung dan berada di ruangan atau lokasi mana.
Apakah masih perlu dijelaskan kembali?
{
    -SM==0:
    +[Iya, Perlu]
        Baiklah, saya ulangi
    ~prefix1=1
    ->prefix
    +[Tidak Perlu, Saya sudah mengingatnya]
        Baiklah, Kita lanjutkan
        ~SM=1
        ->SM_1
    -else:
    -> COBA_1
}
===SM_1
Sekarang coba cari materi tentang Subnet, supaya kamu lebih memahaminya.
-> COBA_1

