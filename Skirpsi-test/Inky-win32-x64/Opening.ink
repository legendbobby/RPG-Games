===Awal
Hello!!
Disini kamu akan disuruh untuk menyelesaikan permasalahan tentang Pengelamatan IP.
Sebelum itu, kamu harus melaksanakan Pelatihan tentang IP Address itu sendiri. Apakah kamu pernah mendengar atau melihat IP Address atau Pengalamatan IP?
+ [Pernah]
    Hoo jadi kamu sudah pernah mendengar tentang Pengalamatan IP
   ->Awal_2
+ [Belum Pernah]
    Baiklah, Saya jelaskan
    ->Awal_IP
===Awal_2
Lalu Apa itu IP?
+ [Sebuah aturan yang membuat satu perangkat dengan perangkat lainnya bisa saling komunikasi satu sama lain]
    Yap betul Sekali 
    ->Awal_IP
+ [IP adalah angka-angka yang berada di Komputer atau Gadget]
    hmm, Kurang Tepat
    ->Awal_IP
+ [Maaf saya Lupa]
    hmm, Ya sudah saya jelaskan
    ->Awal_IP

===Awal_IP
IP atau Internet Protocol, Sebuah aturan yang membuat satu perangkat dengan perangkat lainnya bisa saling komunikasi satu sama lain.
Dianalogikan seperti proses pengiriman Surat. Tukang POS memerlukan alamat Asal dan Tujuan supaya tau arah surat yang akan diantar.Alamat IP adalah sebuah Alamat Rumah (Asal dan Tujuannya). 
Jika tidak ada alamat asal dan tujuan surat susah di-identifikasi, sehingga pengiriman tidak dapat dilakukan. Itu pun berlaku dengan Alamat IP pada sebuah Perangkat atau Gadget.
Tanpa IP, Perangkat tidak akan bisa berkomunikasi atau tidak dapat saling mengenal. Yang dimaksud Komunikasi, contoh nya Mengirim suatu File, Chat lewat Social Media dan sebagainya.
{VAwal==0:
    Setelah medengar penjelasan singkat itu tadi apakah sudah mulai tergambar apa itu Pengalamatan IP?
    + [Iya, Sudah]
    Baiklah kita lanjut untuk pembahasan selanjutnya
        ~ VAwal = 1
        ->Awal_PB
    + [Belum, Tolong ulangi!]
    Baiklah saya ulangi
    ->Awal_IP
  - else:
    ->COBA_1
    }

