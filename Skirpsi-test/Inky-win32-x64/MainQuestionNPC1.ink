===COBA_1
Apa yang ingin anda Tanyakan?
+ [Apa yang harus dilakukan saya sekarang?]
    {
    - StateMisi==1:
        -> MISI_1
    - StateMisi==2 && SM==1:
        -> SM_1
    - SM==2:
        -> MISI_2
    - SM==5:
        ->MISI_2_E
    }
+ [Apa itu IP Address?]
->Awal_IP
+ [Tahap Tahap Problem Solving]
->PB_Akhir
+ [Apa itu IPv4?]
->IP_1
{
- id==1:
    + [Apa itu Host Id dan Network ID?]
    ->ID

}
{
- prefix==1:
    + [Apa itu Prefix dan Subnet Mask?]
    ->prefix
}
{
- SM==4:
    ->SM_2
}

+[Tidak jadi]
    Jangan sungkan untuk bertanya kembali
-> DONE
