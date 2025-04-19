public class CovidConfig
{
    public string satuan_suhu { get; set; }
    public int batas_hari_deman { get; set; }
    public string pesan_ditolak { get; set; }
    public string pesan_diterima { get; set; }

    public CovidConfig()
    {
        satuan_suhu = "celcius";
        batas_hari_deman = 14;
        pesan_ditolak = "Anda tidak diperbolehkan masuk ke dalam gedung ini";
        pesan_diterima = "Anda dipersilahkan untuk masuk ke dalam gedung ini";
    }

    public void UbahSatuan()
    {
        satuan_suhu = satuan_suhu == "celcius" ? "fahrenheit" : "celcius";
    }
}
