namespace gregslist_cSharp.Repositories;

public class CarsRepository
{

  private readonly IDbConnection _db;

  public CarsRepository(IDbConnection db)
  {
    _db = db;
  }

  internal int CreateCar(Car carData)
  {
    string sql = @"
    INSERT INTO cars(
      make, model, price, year, color, hasTires
    )
    values(
      @Make, @Model, @Price, @Year, @Color, @HasTires
    );
    SELECT LAST_INSERT_ID();";

    int id = _db.ExecuteScalar<int>(sql, carData);

    return id;
  }

  internal void EditCar(Car originalCar)
  {
    string sql = @"
    UPDATE cars
    SET
    model = @Model,
    make = @Make,
    price = @Price,
    hasTires = @HasTires
    WHERE id = @Id
    ;";

    _db.Execute(sql, originalCar);
  }

  internal List<Car> GetAll()
  {
    string sql = "SELECT * FROM cars;";

    List<Car> cars = _db.Query<Car>(sql).ToList();
    return cars;
  }

  internal Car GetOne(int carId)
  {
    string sql = "SELECT * FROM cars WHERE id = @carId;";

    Car car = _db.Query<Car>(sql, new { carId }).FirstOrDefault();
    return car;
  }

  internal int Remove(int carId)
  {
    string sql = "DELETE FROM cars WHERE id = @carId LIMIT 1;";

    int rowsAffected = _db.Execute(sql, new { carId });
    return rowsAffected;
  }
}
