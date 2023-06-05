using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Data.Linq.Mapping;
using System.Text;
using System.Threading.Tasks;
using ColumnAttribute = System.ComponentModel.DataAnnotations.Schema.ColumnAttribute;
using TableAttribute = System.Data.Linq.Mapping.TableAttribute;
using System.Data;
using System.Data.Linq.Mapping;


namespace HW2
{
    [Table(Name = "Table")] // Replace "Table" with your actual table name
    public class GameRecordEntity
    {
        [Column(Name = "Id", IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }

        [Column(Name = "Name", DbType = "VARCHAR(50) NOT NULL")]
        public string Name { get; set; }

        [Column(Name = "Length", DbType = "INT NOT NULL")]
        public int Length { get; set; }
    }

}
