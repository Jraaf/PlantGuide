Here is the complete **README.md** generated from the provided OpenAPI specification:

---

# **PlantGuide API**

The **PlantGuide API** provides a comprehensive set of endpoints to manage information about plants, their climates, origins, photos, and more. It follows the OpenAPI specification for consistent and efficient access.

---

## **Table of Contents**
- [Endpoints](#endpoints)
  - [Climate](#climate)
  - [Country](#country)
  - [Family](#family)
  - [Origin](#origin)
  - [Photo](#photo)
  - [Plant](#plant)
  - [Source](#source)
  - [TypeSeason](#typeseason)
- [Schemas](#schemas)
- [License](#license)

---

## **Endpoints**

### **Climate**
| Method | Endpoint                  | Description                       |
|--------|----------------------------|-----------------------------------|
| GET    | `/api/Climate/GetAll`      | Get all climates                 |
| GET    | `/api/Climate/GetById`     | Get a specific climate by ID     |
| POST   | `/api/Climate/add`         | Add a new climate                |
| DELETE | `/api/Climate/Delete`      | Delete a climate by ID           |
| PUT    | `/api/Climate/Update`      | Update a climate by ID           |

---

### **Country**
| Method | Endpoint                  | Description                       |
|--------|----------------------------|-----------------------------------|
| GET    | `/api/Country/GetAll`      | Get all countries                |
| GET    | `/api/Country/GetById`     | Get a specific country by ID     |
| POST   | `/api/Country/add`         | Add a new country                |
| DELETE | `/api/Country/Delete`      | Delete a country by ID           |
| PUT    | `/api/Country/Update`      | Update a country by ID           |

---

### **Family**
| Method | Endpoint                  | Description                       |
|--------|----------------------------|-----------------------------------|
| GET    | `/api/Family/GetAll`       | Get all families                 |
| GET    | `/api/Family/GetById`      | Get a specific family by ID      |
| POST   | `/api/Family/add`          | Add a new family                 |
| DELETE | `/api/Family/Delete`       | Delete a family by ID            |
| PUT    | `/api/Family/Update`       | Update a family by ID            |

---

### **Origin**
| Method | Endpoint                  | Description                       |
|--------|----------------------------|-----------------------------------|
| GET    | `/api/Origin/GetAll`       | Get all origins                  |
| GET    | `/api/Origin/GetById`      | Get a specific origin by ID      |
| POST   | `/api/Origin/add`          | Add a new origin                 |
| DELETE | `/api/Origin/Delete`       | Delete an origin by ID           |
| PUT    | `/api/Origin/Update`       | Update an origin by ID           |

---

### **Photo**
| Method | Endpoint                  | Description                       |
|--------|----------------------------|-----------------------------------|
| GET    | `/api/Photo/GetAll`        | Get all photos                   |
| GET    | `/api/Photo/GetById`       | Get a specific photo by ID       |
| POST   | `/api/Photo/add`           | Add a new photo                  |
| DELETE | `/api/Photo/Delete`        | Delete a photo by ID             |
| PUT    | `/api/Photo/Update`        | Update a photo by ID             |

---

### **Plant**
| Method | Endpoint                  | Description                       |
|--------|----------------------------|-----------------------------------|
| GET    | `/api/Plant/GetAll`        | Get all plants                   |
| GET    | `/api/Plant/GetById`       | Get a specific plant by ID       |
| POST   | `/api/Plant/add`           | Add a new plant                  |
| DELETE | `/api/Plant/Delete`        | Delete a plant by ID             |
| PUT    | `/api/Plant/Update`        | Update a plant by ID             |

---

### **Source**
| Method | Endpoint                  | Description                       |
|--------|----------------------------|-----------------------------------|
| GET    | `/api/Source/GetAll`       | Get all sources                  |
| GET    | `/api/Source/GetById`      | Get a specific source by ID      |
| POST   | `/api/Source/add`          | Add a new source                 |
| DELETE | `/api/Source/Delete`       | Delete a source by ID            |
| PUT    | `/api/Source/Update`       | Update a source by ID            |

---

### **TypeSeason**
| Method | Endpoint                  | Description                       |
|--------|----------------------------|-----------------------------------|
| GET    | `/api/TypeSeason/GetAll`   | Get all type seasons             |
| GET    | `/api/TypeSeason/GetById`  | Get a specific type season by ID |
| POST   | `/api/TypeSeason/add`      | Add a new type season            |
| DELETE | `/api/TypeSeason/Delete`   | Delete a type season by ID       |
| PUT    | `/api/TypeSeason/Update`   | Update a type season by ID       |

---

## **Schemas**

### **CreateClimateDTO**
```json
{
  "plantId": "integer (nullable)",
  "name": "string (nullable)",
  "description": "string (nullable)",
  "temperatureMin": "number (nullable)",
  "temperatureMax": "number (nullable)",
  "precipitationMin": "number (nullable)",
  "precipitationMax": "number (nullable)"
}
```

### **CreateCountryDTO**
```json
{
  "name": "string (nullable)"
}
```

### **CreateFamilyDTO**
```json
{
  "name": "string (nullable)"
}
```

### **CreateOriginDTO**
```json
{
  "plantId": "integer (nullable)",
  "countryId": "integer (nullable)",
  "years": "integer (nullable)"
}
```

### **CreatePhotoDTO**
```json
{
  "plantId": "integer (nullable)",
  "url": "string (nullable)",
  "author": "string (nullable)"
}
```

### **CreatePlantDTO**
```json
{
  "scientificName": "string (nullable)",
  "commonName": "string (nullable)",
  "description": "string (nullable)"
}
```

### **CreateSourceDTO**
```json
{
  "title": "string (nullable)",
  "url": "string (nullable)",
  "author": "string (nullable)"
}
```

### **CreateTypeSeasonDTO**
```json
{
  "name": "string (nullable)"
}
```

---

## **License**

MIT License. You are free to use and modify this API.

---

Let me know if you need any adjustments or more details!
