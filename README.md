# DevQuest

Math Api to calculate all divisor for a positive integer and primes among the divisors

## Getting Started

These instructions will get you a copy of the project up and running on your local machine for development and testing purposes. See deployment for notes on how to deploy the project on a live system.

### Prerequisites

What things you need to install the software and how to install them

```
Docker
```

### Installing

A step by step series of examples that tell you how to get a development env running

Say what the step will be

```
docker build -t mymathapi-image -f Dockerfile . 
docker run -it --rm -p 5000:5000 -e ASPNETCORE_URLS=http://0.0.0.0:5000 -d mymathapi-image
```
## Running

To run the API just open your browser and type  

```
https://localhost:5000/swagger
```

## Authors

* **Alexandre Coelho** - *Initial work* - (https://github.com/alexandrescoelho)

See also the list of [contributors](https://github.com/your/project/contributors) who participated in this project.

## License

This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details