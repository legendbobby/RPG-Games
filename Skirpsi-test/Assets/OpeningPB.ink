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