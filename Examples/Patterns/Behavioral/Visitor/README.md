# Visitor Pattern

1. Intent

   Allows you to add new behaviors to an existing object structure without modifying the objects themselves.

2. The Context (Problem)

    A patient's file contains different elements:

    - BloodTest: Contains hemoglobin, glucose levels.

    - XRay: Contains image path and radiologist notes.

    The Problem: You have several departments that need to "read" this report:

    - Billing Department: Needs to calculate the cost of each test.

    - Risk AI: Needs to scan the values to find life-threatening patterns.

    - Research Team: Needs to anonymize the data for a study.
