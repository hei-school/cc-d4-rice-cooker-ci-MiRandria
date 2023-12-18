[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-24ddc0f5d75046c5622901739e7c5dd533143b0c8e959d652212380cedb1ea36.svg)](https://classroom.github.com/a/__xb4cFP)
# Rice Cooker CI Application

## Overview

This is a simple rice cooker application written in TypeScript, python, C# and ruby. It provides basic functionalities for cooking rice, including monitoring for overheating during the cooking process and ensuring the quality of the rice meets specified criteria.

## Functionalities:

- **Cook Rice (cuireRiz):**
  - Initiates the rice cooking process.
  - Monitors for overheating during the cooking process.
  - Ensures the quality of the rice meets specified criteria.
  - Example: `cuiseur.cuireRiz();`

- **Keep Warm (maintienChaud):**
  - Maintains the cooked rice warm for a specified duration.
  - Example: `cuiseur.maintienChaud();`
    
## Note

- Adjust the temperature and quality criteria in the code according to your preferences or specific requirements.

## Continuous Integration with CircleCI

We use CircleCI for continuous integration to ensure that the application builds successfully and passes unit tests across multiple languages. The configuration for CircleCI can be found in the `.circleci/config.yml` file in the repository.

