# Slavica
Rework of the [old project I've made once](https://github.com/SovietModernism/slavic-comparator). This time I decided to go for C# and make it complete.

The idea behind it is as simple as possible — you enter a word in English, Slavica shows you a bunch of translations for all Slavic languages available. The whole translation process relies on the online Glosbe vocabulary and its API, so the app itself is just an intermediary between user and vocabulary.

____

Classes:
- Scrapper.cs — getting the raw response from Glosbe
- Parser.cs — processing the response into words translated
- Window.cs — maintaining UI stuff and connecting app parts to each other
