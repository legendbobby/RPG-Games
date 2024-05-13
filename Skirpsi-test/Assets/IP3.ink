===prefix
Saat kalian melihat IP Address di komputer atau Gadget kalian kalian sering juga melihat nomor seperti IP Address berdampingan IP Addressnya yakni Subnet Mask dan prefix
Subnet mask bentuknya seperti IP Address, dia punya 4 Oktet dan bisa dikonversi ke biner yang terdiri dari 32 bit, Subnet Mask sendiri adalah sebagai pembagi atau pemecah suatu jaringan. 
Jika kalian tidak melihat subnet mask namum melihat slash nomer (contoh /24) itu disebut prefix. Prefix adalah nomer pengganti subnet mask, Prefix biasanya terlihat di belakang IP address itu sendiri sebagai contoh 192.168.88.254 /24.
/24 itu sendiri merupakan banyaknya angka biner.Contoh nya sendiri subnet mask 255.255.255.0 yang biasa kalian lihat, dan jika dikonversi kebiner menjadi 11111111.11111111.11111111.00000000
Jika kalian hitung jumlah total angka 1 nya berjumlah 24 sehingga prefixnya /24,Sebagai contoh lain 255.255.255.192 kebiner menjadi 11111111.11111111.11111111.11000000 dengan prefix nya adalah /26
Tambahan Informasi berhubungan dengan Subnet Mask, Pembagian jaringan diperlukan untuk keamanan jaringan itu sendiri atau mempermudah manajemen jaringan sehingga kita tidak pusing perangkat mana yang terhubung beraada diruangan atau lokasi mana.
Apakah masih perlu dijelaskan kembali?
{
    -SM==0:
    +[Iya, Perlu]
        Baiklah, saya ulangi
    ->prefix
    +[Tidak Perlu, Saya sudah mengingatnya]
        Baiklah, Kita lanjutkan
        ~SM=1
        ->DONE
    -else:
    -> COBA_1
}
