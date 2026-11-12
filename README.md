                                 ╭─────────────────────╮
                                 │ Školní Projekt Kvíz │
                                 ╰─────────────────────╯

# Školní projekt Kvíz

Tvoříme konzolový kvíz v jazyce C# pro tři členy týmu.
Hlavním cílem projektu je naučit se spolupracovat přes GitHub:
rozdělovat si úkoly, upravovat projekt ve větvích a kontrolovat
změny ostatních členů.

## Členové týmu

- **MarekKunovsky** – správce repozitáře, hlavní menu a průběh hry (`Program.cs`, `Kviz.cs`).
- **strestik** – otázky (`Otazka.cs`, `SpravaOtazek.cs`, `UkazkoveOtazky.cs`), navržená role správce úkolů.
- **Listik2009** – hráči (`Hrac.cs`, `SpravaHracu.cs`), navržená role správce dokumentace a testů.

## Téma kvízu

Hlavní města světa. Hráč dostane název hlavního města
a vybere ze čtyř možností stát, ke kterému město patří.
Před každým kolem si hráč vybere lehkou, střední nebo těžkou obtížnost.
Program ze seznamu náhodně vybere pět různých otázek stejné obtížnosti.

## Plánované funkce

- Přidávání, vypisování a mazání otázek.
- Registrace a výpis hráčů.
- Hraní kvízu a vyhodnocování odpovědí.
- Počítání bodů a zobrazení žebříčku hráčů.

## Technologie

- C#
- .NET 8
- Visual Studio 2022 nebo novější

## Dohoda o spolupráci

1. Pro domluvu používáme **[DOPLŇ DOMLUVENÝ KANÁL]**.
2. Větev pro úkol pojmenujeme `ukol-<číslo>-<popis>`, například `ukol-5-pridani-otazky`. Pro první README používáme větev `readme`.
3. Zprávy commitů píšeme česky a popíšeme v nich konkrétní změnu.
4. Změnu posíláme z pracovní větve do `main` přes pull request. V popisu uvedeme číslo úkolu, co se změnilo a co jsme ověřili.
5. Pull request před sloučením zkontroluje alespoň jeden další člen týmu. Uvede, co ověřil a co se má případně opravit.

## Spuštění

1. Otevři `Kviz.sln` ve Visual Studiu 2022 nebo novějším s podporou .NET 8.
2. Sestav řešení přes **Sestavení → Sestavit řešení** nebo zkratkou **Ctrl+Shift+B**.
3. Stiskni **Ctrl+F5** pro spuštění bez ladění.
4. V hotové verzi zvol **6 – Hrát kvíz**, vyber hráče a obtížnost. Program nabídne pět vylosovaných otázek.
5. Volbou **0 – Konec** program ukončíš.

Hráči, výsledky a změny v otázkách jsou v paměti po dobu běhu programu. Po spuštění se znovu načtou ukázková data.

Projekt je zatím rozpracovaný.
