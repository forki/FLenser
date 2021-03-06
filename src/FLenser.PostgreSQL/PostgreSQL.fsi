﻿(*  FLenser, a simple ORM for F#
    Copyright (C) 2015 Eric Stokes 

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU Library General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>. *)
module FLenser.PostgreSQL.Provider
open System
open Npgsql
open FLenser.Core

val create: NpgsqlConnectionStringBuilder 
    -> Provider<NpgsqlConnection,NpgsqlParameter,NpgsqlTransaction>

(* give the postgres type associated with the specified type, or raise Failure if there is
   no mapping. *)
val pgTypeName: Type -> String
