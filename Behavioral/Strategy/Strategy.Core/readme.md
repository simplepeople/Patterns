Strategy is a behavioral design pattern that lets you define a family of algorithms, put each of them into a separate class, and make their objects interchangeable.

```mermaid
---
title: Strategy
---
classDiagram

    class LogProcessor{
        - logReader : ILogReader
        + FilterLogs()
    }
    class ILogReader{
        <<interface>>
        + ReadLogs()
    }
    ILogReader --o LogProcessor



    class FileLogReader
    ILogReader <|-- FileLogReader
    
    class WindowsEventFileReader
    ILogReader <|-- WindowsEventFileReader
```