## Abstract Factory Pattern

1. Intent

   Provides an interface for creating families of related or dependent objects without specifying their concrete classes.

2. The Context (Problem)

   You are building a Furniture Simulator. You have different styles of furniture:
   - ArtDeco: ArtDecoChair, ArtDecoSofa.
   - Victorian: VictorianChair, VictorianSofa.
   - Modern: ModernChair, ModernSofa.

   The Problem: If a customer wants a Modern living room, you cannot give them a Modern Chair but a Victorian Sofa. They don't match! Your code needs a way to ensure that all pieces of furniture created belong to the same style "family."
