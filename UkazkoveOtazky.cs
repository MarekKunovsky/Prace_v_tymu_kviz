namespace KvizProjekt;

internal static class UkazkoveOtazky
{
    internal static Otazka[] Vytvor()
    {
        return
        [
            // Lehká obtížnost
            new("Praha", "Evropa", 1, ["Slovensko", "Česko", "Rakousko", "Polsko"], 2),
            new("Bratislava", "Evropa", 1, ["Slovinsko", "Chorvatsko", "Maďarsko", "Slovensko"], 4),
            new("Vídeň", "Evropa", 1, ["Rakousko", "Německo", "Švýcarsko", "Lichtenštejnsko"], 1),
            new("Berlín", "Evropa", 1, ["Nizozemsko", "Belgie", "Německo", "Rakousko"], 3),
            new("Paříž", "Evropa", 1, ["Francie", "Belgie", "Lucembursko", "Švýcarsko"], 1),
            new("Řím", "Evropa", 1, ["Španělsko", "Itálie", "Portugalsko", "Řecko"], 2),
            new("Londýn", "Evropa", 1, ["Irsko", "Nizozemsko", "Dánsko", "Spojené království"], 4),
            new("Varšava", "Evropa", 1, ["Česko", "Litva", "Polsko", "Rumunsko"], 3),
            new("Tokio", "Asie", 1, ["Čína", "Japonsko", "Jižní Korea", "Vietnam"], 2),
            new("Káhira", "Afrika", 1, ["Libye", "Tunisko", "Alžírsko", "Egypt"], 4),
            new("Madrid", "Evropa", 1, ["Francie", "Portugalsko", "Španělsko", "Itálie"], 3),
            new("Washington, D.C.", "Severní Amerika", 1, ["Spojené státy americké", "Kanada", "Mexiko", "Kostarika"], 1),
            new("Budapešť", "Evropa", 1, ["Rumunsko", "Srbsko", "Slovensko", "Maďarsko"], 4),
            new("Atény", "Evropa", 1, ["Albánie", "Řecko", "Chorvatsko", "Bulharsko"], 2),
            new("Kyjev", "Evropa", 1, ["Polsko", "Moldavsko", "Ukrajina", "Rumunsko"], 3),

            // Střední obtížnost
            new("Lisabon", "Evropa", 2, ["Španělsko", "Itálie", "Portugalsko", "Řecko"], 3),
            new("Stockholm", "Evropa", 2, ["Norsko", "Švédsko", "Dánsko", "Finsko"], 2),
            new("Oslo", "Evropa", 2, ["Švédsko", "Dánsko", "Island", "Norsko"], 4),
            new("Helsinky", "Evropa", 2, ["Finsko", "Švédsko", "Norsko", "Estonsko"], 1),
            new("Dublin", "Evropa", 2, ["Spojené království", "Irsko", "Island", "Dánsko"], 2),
            new("Ottawa", "Severní Amerika", 2, ["Kanada", "Spojené státy americké", "Austrálie", "Nový Zéland"], 1),
            new("Canberra", "Oceánie", 2, ["Nový Zéland", "Kanada", "Austrálie", "Fidži"], 3),
            new("Buenos Aires", "Jižní Amerika", 2, ["Chile", "Uruguay", "Paraguay", "Argentina"], 4),
            new("Brasília", "Jižní Amerika", 2, ["Ekvádor", "Kolumbie", "Brazílie", "Peru"], 3),
            new("Soul", "Asie", 2, ["Severní Korea", "Jižní Korea", "Čína", "Japonsko"], 2),
            new("Kodaň", "Evropa", 2, ["Švédsko", "Norsko", "Nizozemsko", "Dánsko"], 4),
            new("Wellington", "Oceánie", 2, ["Nový Zéland", "Austrálie", "Fidži", "Samoa"], 1),
            new("Ciudad de México", "Severní Amerika", 2, ["Panama", "Mexiko", "Guatemala", "Kolumbie"], 2),
            new("Bangkok", "Asie", 2, ["Vietnam", "Malajsie", "Thajsko", "Kambodža"], 3),
            new("Santiago de Chile", "Jižní Amerika", 2, ["Chile", "Peru", "Argentina", "Ekvádor"], 1),

            // Těžká obtížnost
            new("Kišiněv", "Evropa", 3, ["Rumunsko", "Bulharsko", "Ukrajina", "Moldavsko"], 4),
            new("Podgorica", "Evropa", 3, ["Bosna a Hercegovina", "Černá Hora", "Srbsko", "Severní Makedonie"], 2),
            new("Biškek", "Asie", 3, ["Kazachstán", "Tádžikistán", "Kyrgyzstán", "Uzbekistán"], 3),
            new("Dušanbe", "Asie", 3, ["Tádžikistán", "Kyrgyzstán", "Uzbekistán", "Turkmenistán"], 1),
            new("Vientiane", "Asie", 3, ["Kambodža", "Vietnam", "Thajsko", "Laos"], 4),
            new("Ulánbátar", "Asie", 3, ["Mongolsko", "Kazachstán", "Nepál", "Bhútán"], 1),
            new("Kigali", "Afrika", 3, ["Burundi", "Rwanda", "Uganda", "Tanzanie"], 2),
            new("Gaborone", "Afrika", 3, ["Namibie", "Zambie", "Botswana", "Zimbabwe"], 3),
            new("Suva", "Oceánie", 3, ["Samoa", "Fidži", "Tonga", "Vanuatu"], 2),
            new("Belmopan", "Severní Amerika", 3, ["Guatemala", "Honduras", "Salvador", "Belize"], 4),
            new("Thimphu", "Asie", 3, ["Bhútán", "Nepál", "Bangladéš", "Laos"], 1),
            new("Maskat", "Asie", 3, ["Bahrajn", "Katar", "Omán", "Kuvajt"], 3),
            new("Nuakšott", "Afrika", 3, ["Mali", "Senegal", "Niger", "Mauritánie"], 4),
            new("Port Louis", "Afrika", 3, ["Seychely", "Mauricius", "Komory", "Madagaskar"], 2),
            new("Paramaribo", "Jižní Amerika", 3, ["Surinam", "Guyana", "Venezuela", "Ekvádor"], 1),
        ];
    }
}
