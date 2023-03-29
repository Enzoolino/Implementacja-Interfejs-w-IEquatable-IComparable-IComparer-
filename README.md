# Implementacja interfejsów `IEquatable`, `IComparable`, `IComparer`

Celem ćwiczenia jest nabycie umiejętności w zakresie tworzenia "dobrze uformowanych typów" (_well formed types_) i implementowania podstawowych interfejsów umożliwiających porównywanie obiektów i stosowanie bibliotecznych algorytmów (sortowanie, wyszukiwanie).

Po wykonaniu ćwiczenia powinieneś:

* umieć implementować równość obiektów (w sensie "taki sam") - implementacja `IEquatable<T>`, przesłonięcie `Equals`, `GetHashCode`,

* umieć określać naturalny porządek dla projektowanego typu - implementacja `IComparable` i wykorzystać go w procesie sortowania i wyszukiwania,

* umieć określać porządek w zbiorze elementów danego typu poprzez wykorzystanie interfejsu `IComparer` oraz delegata `Comparison` i wykorzystać go w procesie sortowania i wyszukiwania,

* umieć zaprogramować prostą metodę generyczną (na przykładzie metody sortującej),

* umieć wykorzystać w praktyce implementację algorytmu wyszukiwania binarnego (metoda `BinarySearch` w klasie `Array` oraz `List<T>`),

* poznać środowisko programowania VisualCode w aspekcie programowania w C#.

> Ćwiczenie wykonaj wykorzystując lekkie środowisko VS Code z dodatkiem C# ( [Get started with C# and Visual Studio Code](https://docs.microsoft.com/pl-pl/dotnet/core/tutorials/with-visual-studio-code) ). Należy zainstalować dodatek: [C# for Visual Studio Code (powered by OmniSharp) by Microsoft](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csharp). Dodatkowo, możesz zainstalować dodatki:
> * [vscode-solution-explorer by Fernando Escolar](https://marketplace.visualstudio.com/items?itemName=fernandoescolar.vscode-solution-explorer)
> * [.NET Core Test Explorer](https://marketplace.visualstudio.com/items?itemName=formulahendry.dotnet-test-explorer)
> 
> Wszystkie polecenia tworzenia czy uruchamiania możesz jednak wydawać z poziomu terminala. Więcej informacji: <https://docs.microsoft.com/en-US/dotnet/core/tools/> (polecenia: <kbd>dotnet new sln</kbd>, <kbd>dotnet new console</kbd>, <kbd>dotnet new classlib</kbd>, <kbd>dotnet new mstest</kbd>, <kbd>dotnet new xunit</kbd>, <kbd>dotnet add ...</kbd>, <kbd>dotnet run</kbd>, <kbd>dotnet test</kbd>, ... ).
> 
> Opisy innych rozszerzeń VS Code przydatnych dla programisty .Net znajdziesz w [Top 5  VS Code Extensions for .Net Core](https://marcroussy.com/2018/03/10/top-5-visual-studio-code-extensions-for-dotnetcore/).
> Więcej informacji o pracy z C# z wykorzystaniem VS Code znajdziesz w dokumentacji Microsoft: [VS Code. Working with C#](https://code.visualstudio.com/docs/languages/csharp)

Obowiązkowa literatura: Michaelis, Rozdział 10. Well formed types

---

Wykonaj kolejno podane [kroki](./docs/index.md).
