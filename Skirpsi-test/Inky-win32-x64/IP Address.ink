VAR VAwal = 0
VAR VPB1 =0
VAR VPB2 =0
VAR VPB3 =0
VAR VPB4 =0
VAR PBAk=0
VAR Tahap1=0
VAR IP1=0
VAR StateMisi=1
VAR id=0
VAR SM=0
VAR PR=0
VAR ip3=0
->Awal
===Awal
Hello!!
Disini kamu akan disuruh untuk menyelesaikan permasalahan tentang Pengelamatan IP.
Sebelum itu, Kamu harus melaksanakan Pelatihan tentang IP Address itu sendiri. Apakah Kamu pernah mendengar atau melihat IP Address atau Pengalamatan IP?
+ [pernah]
    Hoo jadi kamu sudah pernah mendengar tentang Pengalamatn IP
   ->Awal_2
+ [Belum Pernah]
    Baiklah, Saya jelaskan
    ->Awal_IP
===Awal_2
Lalu Apa itu IP?
+ [Sebuah Aturan yang membuat satu perangkat dengan perangkat lainnya bisa saling komunikasi satu sama lain]
    Yap betul Sekali 
    ->Awal_IP
+ [IP adalah angka angka yang berada di Komputer atau Gadget]
    hmm, Kurang Tepat
    ->Awal_IP
+ [Maaf Saya Lupa]
    hmm, ya sudah saya jelaskan
    ->Awal_IP

===Awal_IP
IP atau Internet Protocol, Sebuah Aturan yang membuat satu perangkat dengan perangkat lainnya bisa saling komunikasi satu sama lain.
Dianalogikan seperti proses Pengiriman Surat. Tukang POS memerlukan alamat Asal dan Tujuan supaya tau arah Surat yang akan diatar.Alamat IP adalah sebuah Alamat Rumah (Asal dan Tujuannya). 
Jika tidak ada Alamat asal dan tujuan surat susah diidentifikasi, sehingga pengiriman tidak dapat dilakukan. Itu pun berlaku dengan Alamat IP pada sebuah Perangkat atau Gadget.
Tanpa IP, Perangkat tidak akan bisa berkomunikasi atau tidak dapat saling mengenal. Yang dimaksud Komunikasi, contoh nya Mengirim suatu File, Chat lewat Social Media dan sebagainya.
{VAwal==0:
    Setelah Medengar penjelasan singkat itu tadi apakah sudah mulai tergambar apa itu Pengalamatan IP?
    + [Iya, Sudah]
    Baiklah Kita lanjut untuk pembahasan selanjutnya
        ~ VAwal = 1
        ->Awal_PB
    + [Belum, Tolong ulangi!]
    Baiklah Saya ulangi
    ->Awal_IP
  - else:
    ->COBA_1
    }


===Awal_PB
Untuk menyelesaikan Masalah kamu perlu tau metode cara penyelesainya, Salah satu metode untuk penyelesaian masalah adalah Problem Solving oleh Polya.
+ [Polya?]
    Polya atau George Polya salah satu profesor di bidang Matematika dan juga membuat tahap tahap untuk mempermudah Problem Solving
    Ada 4 Tahap Problem solving: 1. Understand the Problem 2. Devise a Plan 3. Carry out the Plan 4. Loop Back
    -> PB_1
===PB_1
Pada tahap pertama yakni Understand the Problem, Kamu perlu melihat informasi pada permasalahan yang terjadi. Biasanya pada tahap Understand the Problem, kamu menulis Diketahui dan Ditanyakan.
{VPB1==0:
Untuk Tahap ini perlu saya ulangi?
    + [Iya perlu]
    ->PB_1
    + [Tidak Perlu]
    Baiklah Kita Lanjutkan ke Tahap Selanjutnya
     ~VPB1=1
    ->PB_2
  - else:
    -> PB_Akhir
}
===PB_2
Pada Tahap kedua yakni Devise a Plan, Kamu perlu menulis perencanaan untuk menyelesaikan permasalahan. Biasanya pada tahapi ini kamu menulis sebuah rumus dan tahap tahap untuk memecahkan masalah tersebut,
Contonya saat mencari garis miring pada segitiga, kamu perlu menulis rumus pythagoras terlebih dahulu
{VPB2==0:
Untuk Tahap ini perlu saya ulangi?
    + [Iya perlu]
    ->PB_2
    + [Tidak Perlu]
    Baiklah Kita Lanjutkan ke Tahap Selanjutnya
     ~VPB2=1
    ->PB_3
  - else:
    -> PB_Akhir
}
===PB_3
Pada Tahap ketiga yakni Carry out the Plan, Kamu perlu untuk mememasukan informasi pada tahap pertama ke dalam langka langkah yang sudah direncanakan pada Tahap kedua dan menjalankan rencana tersebut. 
Biasanya kamu melakukan proses penyelesaian permasalahan pada tahap ini. Seperti meyelesaikan Soal pada umumnya.
{VPB3==0:
Untuk Tahap ini perlu saya ulangi?
    + [Iya perlu]
    ->PB_3
    + [Tidak Perlu]
    Baiklah Kita Lanjutkan ke Tahap Selanjutnya
     ~VPB3=1
    ->PB_4
  - else:
    -> PB_Akhir
}

===PB_4
Pada tahap keempat atau terakhir yakni Loop Back, Kamu perlu memeriksa kembali pekerjaan yang sudah kamu lakukan dari Tahap kesatu sampai ketiga, Jika ada kesalahan dapat dapat diperbaiki lalu memeriksa kembali sampai benar benar sampai tidak ada kesalahan
{VPB4==0:
Untuk Tahap ini perlu saya ulangi?
    + [Iya perlu]
    ->PB_4
    + [Tidak Perlu]
    Baiklah Kita Lanjutkan.
     ~VPB4=1
    ->PB_Akhir
  - else:
    -> PB_Akhir
}

===PB_Akhir

{
    - PBAk==0:
        Setelah dijelaskan semua tahap Problem Solving, Apakah masih bisa diingat?
    -else:
        Apa yang ingin anda tanyakan?
       
}
+ [Saya Lupa Tahap Understand the Problem]
    -> PB_1
+ [Saya Lupa Tahap Devise A Plan]
    -> PB_2
+ [Saya Lupa Tahap Carry out the Plan]
    -> PB_3
+ [Saya Lupa Tahap Loop Back]
    -> PB_4
+ [Saya sudah mengingat Semuanya]
{
    -Tahap1==0:
        Baikah, Kita Lanjut ke Materi IP Address
            ~Tahap1=1
            ~PBAk=1
            -> IP_1
    -else:
        ->COBA_1
}
    
    
===IP_1
IP Address khusus nya IPv4 mempunyai angka sebanyak 32-bit terdiri dari 4 bagian yang berarti 1 bagiannya terdiri dari 8 bit. Namun kita biasanya melihat dengan bantuk seperti ini: 192.168.88.1. Bentuk tersebut sudah dikonversi dari biner ke desimal supaya mudah diingat dan dibaca.
Sebagai contoh 192.168.88.1 dalam bentuk 32-bit atau biner nya menjadi: 11000000. 10101000.01011000.00000001. Setiap bagian dibatasi dengan titik dan sebagai contoh kita ambil bagian pertama (11000000), bagian ini disebut Oktet pertama. satu Oktek mempunyai 8 bit. Sehingga IP address secara total mempunyai 4 Oktet dan 32-bit angka.
IP Address khususnya IPv4 dibedakan dalam beberapa kelompok. Namum pada saat ini pengelompkan nya jarang digunakan

{
    -IP1==0:
    Apakah saya perlu jelaskan kembali?
     + [Iya perlu]
    Baiklah, saya jelaskan kembali
    ->IP_1
    + [Tidak Perlu]
    Baiklah, Kita Lanjutkan
     ~IP1=1
    ->IP_2
  - else:
    -> COBA_1
}
===IP_2
Supaya kamu tau kelompok IP address nya. Coba cari gambar tabel kelompok tersebut!

->DONE
===IP_3
Wah Kamu sudah menemukannya. Sekarang coba cek di inventory (Untuk melihat isi item coba tekan tombol keyboard "I" atau tekan ikon Tas dipojok bawah kanan.Lalu Klik icon item yang sudah kamu dapatkan) 
-> DONE
===MISI_1
Sekarang untuk menguji pengetahuan kamu, gunakan Informasi yang sudah kamu dapatkan untuk menyelesaikan  masalah tentang Pengelompokkan IPv4. Ada 4 Ruangan, Ruang Istirahat, Perpustakaan, Ruang Petinggi dan Ruang Komputer.
Atur IP Address setiap komputer sesuai kelompok beserta jumlah host yang sesuai dengan kelompoknya. Informasi Kelompok setiap ruangan berada pada gambar di Gudang.
~ip3=1
-> COBA_1
===Tambahan
Selain dengan mencari Item atau gambar, kamu juga bisa cari Informasi lainnya dengan cara bertanya dengan orang lain di tempat ini atau gunakan komputer di ruangan komputer. Jika ingin bertanya hal lain bisa tanyakan saya juga.
->DONE
===COBA_1
Apa yang ingin anda Tanyakan?
+ [Apa yang harus dilakukan saya sekarang?]
    {
    - StateMisi==1:
        -> MISI_1
    }
+ [Apa itu IP Address?]
->Awal_IP
+ [Tahap Tahap Problem Solving]
->PB_Akhir
+ [Apa itu IPv4?]
->IP_1
+ [Bagimana saya mendapatkan Informasi?]
->Tambahan
+[Tidak jadi]
-> DONE

===MISI_1_C
~StateMisi=2
Wah, kamu berhasil menyelesaikan masalah Pengelompokkan IPv4. Sebenarnya Penglompokkan IPv4 sudah jarang digunakan tapi tidak salah juga mempelajari hal itu. ->ID
===ID
Saya jelaskan kembali mungkin ada yang belum dijelaskan. Pada gambar tertera keterangan Network ID dan Host ID. Network ID sebagai Patokan atau penunjuk di kelompok mana atau dimana IP Address itu berasal. Host ID adalah sebagai penunjuk perangkat yang tersambung pada suatu jaringan atau yang terhubung dengan Network ID.
Pada Pengelompokkan IPv4 di tabel bisa dilihat Host ID Kelmpok A berada pada Oktek IP ke-1 dan Host ID nya berada pada Oktet ke-2, 3 dan 4. Kelompok B Host ID nya berada pada Oktek IP ke-1 dan 2 dan Host ID berada pada Oktet ke-3 dan 4 dan kelompok selanjutnya terus mengikuti aturan tersebut.
Ini juga membuktikan bahywa Kelompok A mempunyai tampunngan Host paling banyak, atau dalam Kelompok A bisa banyak Perangkat yang terhubung dibandingkan dengan kelompok lain.
Jika masih bingung Network ID dianalogikan sebagai Komplek atau perumahan dan Host ID sebagai nomor Rumah
    {
        -id==0:
        Apakah masih perlu dijelaskan kembali?
        +[Iya, Perlu]
            Baiklah, saya ulangi
            ->ID
        +[Tidak Perlu, Saya sudah mengingatnya]
            Baiklah, Kita lanjutkan!
            ~id=1
            -> prefix
        - else:
        ->COBA_1
    
    }
    
    
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
