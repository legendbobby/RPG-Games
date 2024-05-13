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

