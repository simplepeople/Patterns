Abstract Factory is a creational design pattern that lets you produce families of related objects without specifying their concrete classes.
```mermaid
---
title: Abstract Factory
---
classDiagram

    class IContent{
        <<interface>>
        + GetTextDesctiption()
    }

    class AudioContent
    IContent <|.. AudioContent

    class VideoContent
    IContent <|.. VideoContent

    IContent <.. ContentFactory

    class ContentFactory{
        <<abstract>>
        + CreateSafeContent() : IContent
        + CreateNSFWContent() : INSFWContent
    }

    class VideoContentFactory{
        + CreateContent() : IContent
        + CreateNSFWContent() : INSFWContent
    }

    ContentFactory <|-- VideoContentFactory

    class AudioContentFactory{
        + CreateContent() : IContent
        + CreateNSFWContent() : INSFWContent
    }
    ContentFactory <|-- AudioContentFactory

    note for AudioContentFactory "return new AudioContent()"


    class INSFWContent{
        <<interface>>
        + GetTextDesctiption()
    }

    class NSFWAudioContent
    INSFWContent <|.. NSFWAudioContent

    class NSFWVideoContent
    INSFWContent <|.. NSFWVideoContent

    INSFWContent <.. ContentFactory

```