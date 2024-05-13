===ID
Saya jelaskan kembali mungkin ada yang belum dijelaskan. Pada IP Address terdapat Network ID dan Host ID. 
Network ID sebagai Patokan atau penunjuk di kelompok mana atau dimana IP Address itu berasal. 
Host ID adalah sebagai penunjuk perangkat yang tersambung pada suatu jaringan atau yang terhubung dengan Network ID.
Pada Pengelompokkan IPv4 di tabel bisa dilihat Host ID Kelmpok A berada pada Oktet IP ke-1 dan Host ID nya berada pada Oktet ke-2, 3 dan 4. Kelompok B Host ID nya berada pada Oktek IP ke-1 dan 2 dan Host ID berada pada Oktet ke-3 dan 4 dan kelompok selanjutnya terus mengikuti aturan tersebut.
Ini juga membuktikan bahwa Kelompok A mempunyai tampungan Host paling banyak, atau dalam Kelompok A bisa banyak Perangkat yang terhubung dibandingkan dengan kelompok lain.
Jika masih bingung Network ID dianalogikan sebagai Komplek atau perumahan dan Host ID sebagai nomor Rumah
    {
        -id==0:
        Apakah masih perlu dijelaskan kembali?
        +[Iya, Perlu]
            Baiklah, saya ulangi
            ->ID
        +[Tidak Perlu, saya sudah mengingatnya]
            Baiklah, kita lanjutkan!
            ~id=1
            -> prefix
        - else:
        ->COBA_1
    
    }