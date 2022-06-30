
---
# *<center>Evolutionary Computation For Optimize The Location Of Base Stations</center>*

*In this project, different types of [**Evolutionary Computation**](https://en.wikipedia.org/wiki/Evolutionary_computation "vikipedia")
methods can be run with different parameters to optimize location of Base Stations.*

The aim is to adjust the location of the Base Stations to minimize the number of Customers not covered by the stations
([**Fitness Function**](https://en.wikipedia.org/wiki/Fitness_function "vikipedia")).

*By following the relevant forms, a City can be created whose borders on the x, y axis 
and the number of Customers are determined (Customer locations will be randomly generated).*

*Optimum methods and parameters for the problem can be discovered by running different types of Evolutionary Computation methods 
on this City with the desired parameters.*

---

### *Version*

- _Microsoft Visual Studio Enterprise 2017 Version: **15.9.17**_
- _C# Version: **7.0**_
- _.Net Framework Version: **4.6.1**_

---

# *<center>Classes</center>*

---

## *Model*

1. **Customer:** This class represents Customers. The class contains the ID of a Customer,
 and the location of the Customer as (x, y) values
See <ins>_/Model/Customer.cs_</ins> file for details.
2. **Base:** This class represents Base Stations. The class contains the ID of a Base Station,
 and the location of the Base Station as (x, y) values
See <ins>_/Model/Base.cs_</ins> file for details.
3. **City:** This class represents City. The class contains borders in the xy-plane, 
a candidate Base Station list, and a Customer list.
Since the coverage radius of all Base Stations will be determined equally, 
it also contains a value to keep the coverage radius of the Base Stations.
See <ins>_/Model/City.cs_</ins> file for details.
4. **CityGenerator:** Class to generate Cities.
This class contains static methods for generating random Customer and candidate Base Station lists for the City.
See <ins>_/Model/CityGenerator.cs_</ins> file for details.

---
## *Problem*

1. **BaseLocation:** Class that represents the variables and functions needed to solve the problem,
such as the [**Fitness Function**](https://en.wikipedia.org/wiki/Fitness_function "vikipedia").
See <ins>_/Problem/BaseLocation.cs_</ins> file for details.

---

## *Solvent*

### - [Genetic Algorithm](https://en.wikipedia.org/wiki/Genetic_algorithm "vikipedia")

1. **Individual:** Class to represent Individuals used in the Genetic Algorithm.
See <ins>_/Solvent/GeneticAlgorithm/Individual.cs_</ins> file for details.
2. **Population:** Class to represent the Population of Individuals.
See <ins>_/Solvent/GeneticAlgorithm/Population.cs_</ins> file for details.
3. **Selection:** Class to represent the Selection operation to be used for the Genetic Algorithm.
See <ins>_/Solvent/GeneticAlgorithm/Selection.cs_</ins> file for details.
4. **Crossover:** Class to represent the Crossover operation to be used for the Genetic Algorithm.
See <ins>_/Solvent/GeneticAlgorithm/Crossover.cs_</ins> file for details.
5. **Mutation:** Class to represent the Mutation operation to be used for the Genetic Algorithm.
See <ins>_/Solvent/GeneticAlgorithm/Mutation.cs_</ins> file for details.
6. **Evolution:** Class to represent Evolution.
This Class starts the Genetic Algorithm and applies the Genetic Algorithm steps to each generation.
See <ins>_/Solvent/GeneticAlgorithm/Evolution.cs_</ins> file for details.


### - [Differential Evolution](https://en.wikipedia.org/wiki/Differential_evolution "vikipedia")

1. **DEIndividual:** Class to represent Individuals used in the Differential Evolution.
See <ins>_/Solvent/DifferentialEvolution/DEIndividual.cs_</ins> file for details.
2. **DEPopulation:** Class to represent the Population of Individuals.
See <ins>_/Solvent/DifferentialEvolution/DEPopulation.cs_</ins> file for details.
3. **DECrossover:** Class to represent the Crossover operation to be used for the Differential Evolution.
See <ins>_/Solvent/DifferentialEvolution/DECrossover.cs_</ins> file for details.
4. **DEMutation:** Class to represent the Mutation operation to be used for the Differential Evolution.
See <ins>_/Solvent/DifferentialEvolution/DEMutation.cs_</ins> file for details.
5. **DEEvolution:** Class to represent Evolution.
This Class starts the Differential Evolution and applies the Differential Evolution steps to each generation.
See <ins>_/Solvent/DifferentialEvolution/DEEvolution.cs_</ins> file for details.

---

## *Form*

1. **BaseStation:** This form class is used as Main Menu.
In this menu, first of all, a new City should be created by determining the x, y axis borders and the number of Customers.
Then, the relevant solution form can be opened by clicking the Genetic Algorithm or Differential Evolution button to apply the preferred solution method.
See <ins>_/Form/BaseStation.cs_</ins> file for details.
2. **GeneticAlgorithm:** This form class is used as Genetic Algorithm Menu.
Since the Genetic Algorithm works by selecting the desired number of Base Stations among the desired number of candidates,
in this menu, first of all, candidate Base list should be created by determining the Base size.
After the candidate station list is created, the algorithm can be run by setting the Genetic Algorithm parameters.
See <ins>_/Form/GeneticAlgorithm.cs_</ins> file for details.
3. **DifferentialEvolution:** This form class is used as Differential Evolution Menu.
The algorithm can be run by setting the Differential Evolution parameters.
See <ins>_/Form/DifferentialEvolution.cs_</ins> file for details.

---

## *Program*

1. **Program:** Main Function is called inside this class and the program starts running.
See <ins>_/Program.cs_</ins> file for details.

---

# *<center>Algorithms</center>*

---

## *Genetic Algorithm*

### - [Selection](https://en.wikipedia.org/wiki/Selection_(genetic_algorithm) "vikipedia")
1. **[Roulette Wheel](https://en.wikipedia.org/wiki/Fitness_proportionate_selection "vikipedia"):** Select operation is done with the Fitness Proportionate Selection method.
See <ins>_/Solvent/GeneticAlgorithm/Selection.cs_</ins> file for details.
2. **[Tournament](https://en.wikipedia.org/wiki/Tournament_selection "vikipedia"):** Select operation is done with the Tournament Selection method.
See <ins>_/Solvent/GeneticAlgorithm/Selection.cs_</ins> file for details.

### - [Crossover](https://en.wikipedia.org/wiki/Crossover_(genetic_algorithm) "vikipedia")
1. **ClassicCrossover:** This Crossover performs permutation Crossover over a single randomly chosen index.
See <ins>_/Solvent/GeneticAlgorithm/Crossover.cs_</ins> file for details.
2. **Order1Crossover:** This Crossover performs the Crossover as a Permutation Crossover over two randomly selected index.
See <ins>_/Solvent/GeneticAlgorithm/Crossover.cs_</ins> file for details.

### - [Mutation](https://en.wikipedia.org/wiki/Mutation_(genetic_algorithm) "vikipedia")
1. **ClassicMutation:** This mutation calculates the number of genes that need to be changed over the Individual Mutation Rate
And randomly changes this number of genes.
See <ins>_/Solvent/GeneticAlgorithm/Mutation.cs_</ins> file for details.
2. **StepMutation:** StepMutation name is representative only. This mutation, going around all the genes of the chromosome to be mutated one by one
And changing each one with a probability of Individual Mutation Rate.
See <ins>_/Solvent/GeneticAlgorithm/Mutation.cs_</ins> file for details.

---

## *Differential Evolution*

### - [Crossover](https://www.sciencedirect.com/science/article/abs/pii/S1568494609000325 "sciencedirect")
1. **DECrossoverType1:** Differential Evolution is a mutation based algorithm. 
In Differential Evolution algorithms the crossover operator allows the construction of a new trial element starting from the current and mutant elements.
See <ins>_/Solvent/DifferentialEvolution/DECrossover.cs_</ins> file for details.

### - [Mutation](https://arxiv.org/ftp/arxiv/papers/1510/1510.02516.pdf "arxiv")
1. **DEMutationType1(DE/rand/1):** See <ins>_/Solvent/DifferentialEvolution/DEMutation.cs_</ins> file for details.
2. **DEMutationType2(DE/rand/2):** See <ins>_/Solvent/DifferentialEvolution/DEMutation.cs_</ins> file for details.
3. **DEMutationType3(DE/best/1):** See <ins>_/Solvent/DifferentialEvolution/DEMutation.cs_</ins> file for details.
4. **DEMutationType4(DE/best/2):** See <ins>_/Solvent/DifferentialEvolution/DEMutation.cs_</ins> file for details.
5. **DEMutationType5(DE/current-to-best/1):** See <ins>_/Solvent/DifferentialEvolution/DEMutation.cs_</ins> file for details.

 _**Note:** See [**Differential Evolution Mutation Strategies**](https://arxiv.org/ftp/arxiv/papers/1510/1510.02516.pdf "arxiv")
page 3-4 for more details._

---

# *<center>Running</center>*

---

## *Main Manu*

1. **Width:** Input field for specify maximum x-axis value of the City. x-axis minimum value of the City is 0.
2. **Height:** Input field for specify maximum y-axis value of the City. y-axis minimum value of the City is 0.
3. **Customer Size:** Input field for specify number of Customers to be placed in the City.
4. **Generate New City:** Button for generate City containing randomly placed Customers within City limits.
5. **Genetic Algorithm:** Button for open Genetic Algorithm Menu
5. **Differential Evolution:** Button for open Differential Evolution Menu

---

## *Genetic Algorithm Manu*

1. **Base Size:** input field for specify the number of candidate Base Stations to be created.
2. **Generate:** Button for generate a list of candidate Base Stations at random locations within City limits. This must be done before the algorithm is run.
3. **Select Base Size:** Input field for specify how many Stations the algorithm will select from among the candidates.
4. **Base Radius:** Input field for specify the coverage radius of Stations.
5. **Population Size:** Input field for specify the number of Individuals in the Population in which the Genetic Algorithm will be run.
6. **Selection Type:** Input field for specify the Selection Type.
7. **Tournament Size:** Input field for specify the number of Individuals who will participate in the Tournament. This field will only be visible if the Tournament selection type is selected.
8. **Elite Size:** Input field for specify the number of elite Individuals in the Genetic Algorithm.
9. **Crossover Type:** Input field for specify the Crossover Type.
10. **Mutation Type:** Input field for specify the Mutation Type.
11. **General Mutation Rate:** Input field for specify the General Mutation Rate. This Rate determines the probability of Individuals to mutate.
12. **Individual Mutation Rate:** Input field for specify the Individual Mutation Rate. This rate determines the rate at which the Individual to be mutated will be changed.
13. **Max Iteration:** Input field for specify how many generations the Genetic Algorithm will run.
14. **Repeat:** Input field for specify how many times the algorithm will be run. If this value is greater than one, the averages will be printed at the bottom of the result.
15. **Start:** Button for run the Genetic Algorithm.

---

## *Differential Evolution Menu*

1. **Select Base Size:** Input field for specifying the number of Base Stations to be placed in the City.
2. **Base Radius:** Input field for specify the coverage radius of Stations.
3. **Population Size:** Input field for specify the number of Individuals in the Population in which the Differential Evolution will be run.
4. **Max Iteration:** Input field for specify how many generations the Differential Evolution will run.
5. **Crossover Type:** Input field for specify the Crossover Type. Only one type of Crossover is available.
6. **Mutation Type:** Input field for specify the Mutation Type.
7. **Crossover Rate:** Input field for specify the ratio at which the Mutant Individual affects the new Individual to be created.
8. **Differential Rate:** Input field for specify the Differential ratio used when generating Mutant Individuals.
9. **Repeat:** Input field for specify how many times the algorithm will be run. If this value is greater than one, the averages will be printed at the bottom of the result.
10. **Start:** Button for run the Differential Evolution.

---

# *<center>Result</center>*

---

- _**Note:** The work in this section is not a kind of 
[**Hyperparameter Optimization**](https://en.wikipedia.org/wiki/Hyperparameter_optimization "vikipedia").
In this section, some Parameter Sets are defined instinctively and the performance of algorithms is tested for these Parameter Sets.
Optimizing parameters can improve the performance of algorithms.
See [**This Publication**](https://www.researchgate.net/publication/342790193_Tuning_genetic_algorithm_parameters_using_design_of_experiments "researchgate")._

---

## *Case 1*

1. **X-Axis:** [0, 400]
2. **Y-Axis:** [0, 400]
3. **Customer Size:** 250
4. **Base Size:** 50
5. **Base Radius:** 30

### *Genetic Algorithm Parameters*

| ID | Candidate Size | Population | Elite | Selection | Tournament | Crossover | Mutation | General Rate | Individual Rate | Iteration |
| :---: | :---: | :---: | :---: | :---: | :---: | :---: | :---: | :---: | :---: | :---: |
| 0 | 100 | 100 | 3 | Roulette Wheel | - | Order1 | Step | 0.10 | 0.10 | 100 |
| 1 | 100 | 100 | 3 | Roulette Wheel | - | Order1 | Step | 0.10 | 0.10 | 250 |
| 2 | 100 | 100 | 3 | Tournament | 5 | Classic | Step | 0.15 | 0.10 | 100 |
| 3 | 100 | 75 | 3 | Tournament | 5 | Order1 | Classic | 0.15 | 0.10 | 100 |
| 4 | 100 | 150 | 5 | Tournament | 7 | Order1 | Classic | 0.10 | 0.10 | 100 |
| 5 | 150 | 100 | 3 | Roulette Wheel | - | Order1 | Step | 0.10 | 0.10 | 100 |
| 6 | 150 | 100 | 3 | Roulette Wheel | - | Order1 | Step | 0.10 | 0.10 | 250 |

### *Genetic Algorithm Result*

| ID | Best | Worst | Mean | Median | Standard Deviation | Mean Execution Time(sec) |
| :---: | :---: | :---: | :---: | :---: | :---: | :---: |
| 0 | 58 | 63 | 60.25 | 60.5 | 1.446 | 14.894 |
| 1 | 56 | 60 | 57.70 | 57.5 | 1.081 | 37.822 |
| 2 | 59 | 64 | 61.55 | 62.0 | 1.572 | 14.468 |
| 3 | 60 | 69 | 64.20 | 65.0 | 2.526 | 11.184 |
| 4 | 59 | 66 | 62.25 | 62.0 | 2.149 | 21.953 |
| 5 | 36 | 49 | 40.35 | 40.5 | 2.758 | 21.613 |
| 6 | 34 | 40 | 36.80 | 36.5 | 1.823 | 52.567 |

### *Genetic Algorithm Inference*
By looking at the results of the instinctively selected parameters, 
it can be said that increasing the number of iterations and the number of candidate Base Stations increases the performance.
The number of iterations directly affects the execution time.
Therefore, increasing the number of terations increases the execution time.
The number of candidate Base Stations does not directly affect the execution time.
However, the number of candidates indirectly affects the execution time, as candidates not found in the Chromosome during mutation are calculated.
Therefore, increasing the number of candidate Base Stations increases the execution time.
inferences will be tested in the next case.


### *Differential Evolution Parameters*

| ID | Population | Crossover | Mutation | Crossover Rate | Differential Rate | Iteration |
| :---: | :---: | :---: | :---: | :---: | :---: | :---: |
| 7 | 10 | Classic | DE/rand/1 | 0.10 | 0.10 | 1000 |
| 8 | 20 | Classic | DE/rand/1 | 0.10 | 0.10 | 1000 |
| 9 | 5 | Classic | DE/rand/1 | 0.10 | 0.10 | 1000 |
| 10 | 5 | Classic | DE/rand/2 | 0.10 | 0.10 | 1000 |
| 11 | 5 | Classic | DE/best/1 | 0.10 | 0.10 | 1000 |
| 12 | 5 | Classic | DE/rand/1 | 0.15 | 0.10 | 1000 |
| 13 | 5 | Classic | DE/rand/1 | 0.10 | 0.15 | 1000 |

### *Differential Evolution Result*

| ID | Best | Worst | Mean | Median | Standard Deviation | Mean Execution Time(sec) |
| :---: | :---: | :---: | :---: | :---: | :---: | :---: |
| 7 | 18 | 29 | 23.65 | 23.5 | 3.082 | 12.550 |
| 8 | 24 | 31 | 29.05 | 29.5 | 1.700 | 25.554 |
| 9 | 11 | 27 | 19.25 | 19.5 | 4.722 | 6.024 |
| 10 | 18 | 33 | 24.20 | 24.0 | 3.994 | 6.312 |
| 11 | 15 | 37 | 27.75 | 28.0 | 5.108 | 5.989 |
| 12 | 11 | 30 | 21.45 | 22.0 | 4.784 | 6.050 |
| 13 | 10 | 32 | 22.80 | 23.5 | 5.727 | 6.244 |

### *Differential Evolution Inference*
By looking at the results of the instinctively selected parameters, 
It can be said that reducing the Population size increases performance but decreases stability.
Since the Differential Evolution algorithm processes each Individual in the Population in iterations, the decrease in Population size also decreases the execution time.
inferences will be tested in the next case.

---

## *Case 2*

1. **X-Axis:** [0, 750]
2. **Y-Axis:** [0, 750]
3. **Customer Size:** 500
4. **Base Size:** 75
5. **Base Radius:** 50

### *Genetic Algorithm Parameters*

| ID | Candidate Size | Population | Elite | Selection | Tournament | Crossover | Mutation | General Rate | Individual Rate | Iteration |
| :---: | :---: | :---: | :---: | :---: | :---: | :---: | :---: | :---: | :---: | :---: |
| 14 | 150 | 100 | 3 | Roulette Wheel | - | Order1 | Step | 0.10 | 0.10 | 100 |
| 15 | 150 | 100 | 3 | Roulette Wheel | - | Order1 | Step | 0.10 | 0.10 | 250 |
| 16 | 150 | 100 | 3 | Tournament | 5 | Classic | Step | 0.15 | 0.10 | 100 |
| 17 | 150 | 75 | 3 | Tournament | 5 | Order1 | Classic | 0.15 | 0.10 | 100 |
| 18 | 150 | 150 | 5 | Tournament | 7 | Order1 | Classic | 0.10 | 0.10 | 100 |
| 19 | 225 | 100 | 3 | Roulette Wheel | - | Order1 | Step | 0.10 | 0.10 | 100 |
| 20 | 225 | 100 | 3 | Roulette Wheel | - | Order1 | Step | 0.10 | 0.10 | 250 |

### *Genetic Algorithm Result*

| ID | Best | Worst | Mean | Median | Standard Deviation | Mean Execution Time(sec) |
| :---: | :---: | :---: | :---: | :---: | :---: | :---: |
| 14 | 95 | 106 | 99.10 | 98.5 | 3.127 | 41.704 |
| 15 | 86 | 96 | 89.45 | 89.0 | 2.372 | 103.491 |
| 16 | 97 | 114 | 104.40 | 105.0 | 4.393 | 40.955 |
| 17 | 100 | 116 | 107.65 | 108.0 | 4.146 | 31.196 |
| 18 | 98 | 112 | 103.60 | 103.0 | 4.185 | 60.801 |
| 19 | 66 | 79 | 74.00 | 75.0 | 3.195 | 40.312 |
| 20 | 57 | 68 | 63.20 | 64.0 | 3.188 | 98.260 |

### *Genetic Algorithm Inference*
By looking at the results of the instinctively selected parameters, 
as said in previous inference increasing the number of iterations and the number of candidate Base Stations increases the performance.
The number of iterations directly affects the execution time.
Therefore, increasing the number of iterations increases the execution time.
The number of candidate Base Stations does not directly affect the execution time.
However, the number of candidates indirectly affects the execution time, as candidates not found in the Chromosome during mutation are calculated.
Therefore, increasing the number of candidate Base Stations should have increased the execution time.
However, when the results of the 15th and 20th parameter sets are examined, this increase does not appear in this table.
This situation may have been caused by a different reason that will affect the execution time at runtime.
For example, during the 15th run, the computer's resources may have been used for a different process, such as windows update.


### *Differential Evolution Parameters*

| ID | Population | Crossover | Mutation | Crossover Rate | Differential Rate | Iteration |
| :---: | :---: | :---: | :---: | :---: | :---: | :---: |
| 21 | 10 | Classic | DE/rand/1 | 0.10 | 0.10 | 1000 |
| 22 | 20 | Classic | DE/rand/1 | 0.10 | 0.10 | 1000 |
| 23 | 5 | Classic | DE/rand/1 | 0.10 | 0.10 | 1000 |
| 24 | 5 | Classic | DE/rand/2 | 0.10 | 0.10 | 1000 |
| 25 | 5 | Classic | DE/best/1 | 0.10 | 0.10 | 1000 |
| 26 | 5 | Classic | DE/rand/1 | 0.15 | 0.10 | 1000 |
| 27 | 5 | Classic | DE/rand/1 | 0.10 | 0.15 | 1000 |

### *Differential Evolution Result*

| ID | Best | Worst | Mean | Median | Standard Deviation | Mean Execution Time(sec) |
| :---: | :---: | :---: | :---: | :---: | :---: | :---: |
| 21 | 46 | 68 | 58.70 | 59.5 | 4.646 | 36.505 |
| 22 | 58 | 71 | 65.50 | 65.0 | 3.153 | 74.064 |
| 23 | 27 | 58 | 41.15 | 39.5 | 9.206 | 17.904 |
| 24 | 35 | 65 | 53.25 | 55.0 | 8.258 | 18.122 |
| 25 | 37 | 55 | 45.65 | 44.0 | 6.123 | 17.232 |
| 26 | 25 | 73 | 36.90 | 34.5 | 11.139 | 17.610 |
| 27 | 38 | 67 | 49.85 | 50.5 | 8.671 | 18.108 |

### *Differential Evolution Inference*
By looking at the results of the instinctively selected parameters, 
as said in previous inference reducing the Population size increases performance but decreases stability.
Since the Differential Evolution algorithm processes each Individual in the Population in iterations, the decrease in Population size also decreases the execution time.

---

## *Inference*

Looking at **Case1** and **Case2**, the difference between the execution times of even similar parameter sets will be striking.
This time difference is largely due to the difference between the number of Stations and the number of Customers.
More Base Stations require larger Chromosomes, which increases the execution time of both Evolutionary algorithms.
In addition, the calculation of the fitness values takes time depending on the number of Stations and the number of Customers.
These two reasons increase the **Case2** execution times considerably.

Since this problem is essentially a 
[**Continuous Optimization**](https://en.wikipedia.org/wiki/Continuous_optimization "vikipedia") problem, 
the Genetic Algorithm is only a not-so-good alternative for this problem.
In order to solve this problem with the Genetic Algorithm, random candidate Stations are created and the Genetic Algorithm is expected to choose among these candidates.
And the probability of randomly generated candidates to contain the combination that will provide the best solution is very low.
More random candidates can be generated to increase this probability, but more candidates means the problem grows.
In addition, as the number of candidates increases, the stability decreases and the execution time increases.
Despite all these disadvantages, looking at the results, it can be said that the Genetic Algorithm is more stable than the Differential Evolution.
This is because the search space of the Genetic Algorithm is very small compared to Differential Evolution.
For example, the search space of the Genetic Algorithm for **Case1** is 
[**C(100, 50)**](https://en.wikipedia.org/wiki/Combination "vikipedia"),
while in Differential Evolution it is all real numbers in the range [0, 400] for each of the 50 (x, y) pairs.

Theoretically this is equal to infinity, but in this project the position information is kept in 
[**float**](https://www.w3schools.com/cs/cs_data_types.php "w3schools") data type.
The 7 digit limit in the float data type reduces the search space to a partially limited area.
Despite this limit, Differential Evolution operates in a much larger search space than Genetic Algorithm in this problem.
Although the size of the search space reduces the stability of the Differential Evolution, the results show that the performance of the Differential Evolution is better.
Looking at the tables, it can be seen that the worst results in Differential Evolution are almost equal to the best results in Genetic Algorithm.
Differential Evolution also works faster.

The stability and performance of the Differential Evolution algorithm can be improved by optimizing its parameters and increasing the number of iterations.
Since both Population size and the number of iterations directly affect the running speed, if the number of iterations is increased as the Population size is decreased, the execution time will not change.
Also, this change will increase the performance of the program.
However, since some mutation types in Differential Evolution require 4 Individuals, the Population size should not be reduced below 5.

---

- _**Note:** This project has been prepared in a limited time as a homework for the Evolutionary Computing elective course.
No work has been done to optimize the performance of the algorithms used in the project.
For example, execution time of algorithms can be greatly reduced by using
[**Multiprocessing**](https://en.wikipedia.org/wiki/Multiprocessing "vikipedia") or 
[**Multithreading**](https://en.wikipedia.org/wiki/Multithreading_(computer_architecture) "vikipedia") methods._

---

## <center>_I'd Be Glad If You Report Any Mistakes You Notice._</center>

---