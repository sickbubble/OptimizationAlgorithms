# Optimization Algorithms

This repository contains an implementation of Particle Swarm Optimization (PSO) algorithm with extendable fitness functions. The project is developed in C# and utilizes factory and observer design patterns.

## Particle Swarm Optimization (PSO)

Particle Swarm Optimization is a population-based optimization algorithm inspired by the social behavior of bird flocking or fish schooling. It iteratively optimizes a fitness function by simulating the movement of particles in a search space. Each particle adjusts its position based on its own best-known position and the global best-known position of the swarm.

## Fitness Functions

The implemented PSO algorithm allows for the use of various fitness functions. In this project, the "Sum of Squared Deviations" function is included as an example. You can easily extend the project to include other fitness functions relevant to your optimization problem.

## Project Structure

The codebase follows the factory and observer design patterns to provide a flexible and modular architecture. The factory design pattern allows for the dynamic creation of particles and fitness functions, providing extensibility to the algorithm. The observer design pattern enables decoupling of the optimization process from the user interface, allowing for easier integration into different applications or frameworks.

## Getting Started

To get started with the project, follow these steps:

1. Clone the repository:

2. Open the solution in your preferred C# development environment.

3. Explore the `BaseParticle.cs`, `BaseSwarm.cs`, and `Program.cs` files to understand the implementation details and customize them according to your needs.

4. Run the application and observe the optimization process.

## Contributing

Contributions to this project are welcome! If you have any ideas, suggestions, or improvements, feel free to open an issue or submit a pull request.




