## 🚀 Tecnologias

- ASP.NET Core 5.0

## ✋🏻 Pré-requisitos

- Bando de dados MySQL

## Database script SQL

```sql
CREATE DATABASE `rest_with_aspnet`;
USE `rest_with_aspnet`;
CREATE TABLE IF NOT EXISTS `person` (
  `id` bigint(20) NOT NULL AUTO_INCREMENT,
  `address` varchar(100) NOT NULL,
  `first_name` varchar(80) NOT NULL,
  `gender` varchar(6) NOT NULL,
  `last_name` varchar(80) NOT NULL,
  PRIMARY KEY (`id`)
);
```

## Dependencies

1. Microsoft.AspNetCore.Mvc.Versioning;
2. Pomelo.EntityFrameworkCore.MySql.