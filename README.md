# WorkoutTracker — Sledilnik treningov

## Opis

WorkoutTracker je namizna aplikacija za spremljanje treningov, napisana v C# (Windows Forms). Omogoča ustvarjanje vaj, vodenje treningov v realnem času, beleženje setov (kg, ponovitve, RPE) ter pregled statistik (osebni rekordi, volumen treninga).

## Struktura projekta

- **WorkoutTrackerNEW/** — WinForms aplikacija (GUI) z glavno formo.
- **WorkoutTracker_LibraryNEW/** — lastna knjižnica (Class Library) z vso poslovno logiko.
- **WorkoutTracker_NEW/** — pomožni projekt.

## Zahteve

- Windows 10 ali novejši
- Visual Studio 2019+ (s komponento ".NET desktop development")
- .NET Framework 4.7.2 ali novejši

## Namestitev in poganjanje

1. Klonirajte repozitorij:
   ```
   git clone <url-repozitorija>
   ```
2. Odprite `WorkoutTrackerNEW/WorkoutTrackerNEW.sln` v Visual Studiu.
3. Nastavite `Workout_Tracker_OPR` kot Startup Project (desni klik > Set as Startup Project).
4. Zaženite z **F5** (Debug) ali **Ctrl+F5** (brez debuggerja).

## Navodila za uporabo

### 1. Dodajanje vaj

1. Vpišite **ime vaje** (npr. "Bench Press") in izberite **napravo** (npr. "Klop").
2. Izberite **tip vaje**: Moč, Kardio ali Regeneracija.
3. Odkljukajte **mišične skupine** (npr. Prsa, Triceps).
4. Kliknite **Dodaj vajo**.

Za urejanje/brisanje izberite vajo v seznamu in kliknite ustrezni gumb.

### 2. Vodenje treninga

1. **Start** — zažene uro in prične trening.
2. **Pause** — pavzira časovnik (ponovni klik za nadaljevanje).
3. **End** — zaključi trening.

### 3. Dodajanje setov

1. Izberite **vajo** iz spustnega seznama.
2. Nastavite **kg**, **Reps** in **RPE** (1–10).
3. Kliknite **Dodaj set** — set se prikaže v tabeli, volumen se posodobi.
4. Pri vajah za moč se avtomatsko izračuna **1RM** po Epley formuli.

### 4. Shranjevanje treninga

1. Kliknite **Shrani trening** — če trening še teče, se avtomatsko zaključi.
2. Trening se pojavi v tabeli shranjenih treningov.
3. Za brisanje izberite vrstico in kliknite **Izbriši trening**.

### 5. Statistike

Statistike se osvežujejo avtomatsko ob vsakem shranjenem treningu:

- **PR** — najboljši set po teži med vsemi treningi.
- **Volumen 7/30 dni** — skupni volumen (kg x ponovitve) v zadnjih 7 oz. 30 dneh.
- **Število treningov** — koliko treningov je shranjenih.

## OOP koncepti v projektu

| Koncept | Kje v kodi |
|---|---|
| GUI (ena forma) | `Form1.cs` — razred `Statistika` |
| Lastna knjižnica | `WorkoutTracker_LibraryNEW` |
| Kapsulacija | `TrainingVolume.Value` (private set), `WorkoutSession.Sets` (IReadOnlyList) |
| Konstruktorji / destruktor | `Exercise`, `SetEntry`, `ExerciseType` (privatni), `~Exercise()` |
| Lastnosti z logiko | `Exercise.Name`/`Device` (set), `WorkoutSession.DurationText`/`TotalVolume` (get) |
| Statične metode | `Stats.VolumeLastDays()`, `Stats.BestPR_ByKg()`, `Exercise.ResetIds()` |
| const, static, readonly | `Exercise.MinNameLength`, `Exercise._nextId`, `Exercise.CreatedAt` |
| Preoblaganje operatorjev | `TrainingVolume`: `+`, `>`, `<`, `implicit operator` |
| Dedovanje | `StrengthExercise : Exercise` (OneRepMax, override ToString) |
| Polimorfizem | `List<StatRule>` z `Rule_BestPR` in `Rule_VolumeLastDays` |
| Abstraktni razredi | `StatRule` z abstraktno metodo `Compute()` |
| Vmesniki | `IHasVolume` — implementirata `WorkoutSession` in `SetEntry` |
| Indekserji | `WorkoutSession[int i]` |
| Delegati | `WorkoutEventHandler(WorkoutSession, string)` |
| Dogodki | `OnSetAdded`, `OnWorkoutStarted`, `OnWorkoutEnded`, `OnWorkoutPaused`, `OnWorkoutResumed` |

## Avtor

Sven Reberšak — OPR3 seminarska naloga
