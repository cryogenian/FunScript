﻿module internal FunScript.Regexs

open System.Text.RegularExpressions

let components = 
    [
        ExpressionReplacer.createUnsafe <@ fun (r) -> Regex(r) @> <@ Core.Regex.Create @>
        ExpressionReplacer.createUnsafe <@ fun (r, o) -> Regex(r, o) @> <@ Core.Regex.CreateWithOptions @>

        ExpressionReplacer.createUnsafe <@ fun (r: Regex, s) -> r.IsMatch(s) @> <@ Core.Regex.IsMatch @>
        ExpressionReplacer.createUnsafe <@ fun (r: Regex, s, i) -> r.IsMatch(s, i) @> <@ Core.Regex.IsMatchWithOffset @>
        ExpressionReplacer.createUnsafe <@ fun (s, r) -> Regex.IsMatch(s, r) @> <@ Core.Regex.IsMatchStatic @>
        ExpressionReplacer.createUnsafe <@ fun (s, r, o) -> Regex.IsMatch(s, r, o) @> <@ Core.Regex.IsMatchStaticWithOptions @>

        ExpressionReplacer.createUnsafe <@ fun (r: Regex, s) -> r.Match(s) @> <@ Core.Regex.MatchFirst @>
        ExpressionReplacer.createUnsafe <@ fun (r: Regex, s, i) -> r.Match(s, i) @> <@ Core.Regex.MatchFirstWithOffset @>
        ExpressionReplacer.createUnsafe <@ fun (s, r) -> Regex.Match(s, r) @> <@ Core.Regex.MatchFirstStatic @>
        ExpressionReplacer.createUnsafe <@ fun (s, r, o) -> Regex.Match(s, r, o) @> <@ Core.Regex.MatchFirstStaticWithOptions @>

        ExpressionReplacer.createUnsafe <@ fun (r: Regex, s) -> r.Matches(s) @> <@ Core.Regex.Matches @>
        ExpressionReplacer.createUnsafe <@ fun (r: Regex, s, i) -> r.Matches(s, i) @> <@ Core.Regex.MatchesWithOffset @>
        ExpressionReplacer.createUnsafe <@ fun (s, r) -> Regex.Matches(s, r) @> <@ Core.Regex.MatchesStatic @>
        ExpressionReplacer.createUnsafe <@ fun (s, r, o) -> Regex.Matches(s, r, o) @> <@ Core.Regex.MatchesStaticWithOptions @>

        ExpressionReplacer.createUnsafe <@ fun (r: Regex, s) -> r.Split(s) @> <@ Core.Regex.Split @>
        ExpressionReplacer.createUnsafe <@ fun (s, r) -> Regex.Split(s, r) @> <@ Core.Regex.SplitStatic @>
        ExpressionReplacer.createUnsafe <@ fun (s, r, o) -> Regex.Split(s, r, o) @> <@ Core.Regex.SplitStaticWithOptions @>

        ExpressionReplacer.createUnsafe <@ fun (r: Regex, s, rep) -> r.Replace(s, replacement=rep) @> <@ Core.Regex.Replace @>
        ExpressionReplacer.createUnsafe <@ fun (s, r, rep) -> Regex.Replace(s, r, replacement=rep) @> <@ Core.Regex.ReplaceStatic @>
        ExpressionReplacer.createUnsafe <@ fun (s, r, rep, o) -> Regex.Replace(s, r, replacement=rep, options=o) @> <@ Core.Regex.ReplaceStaticWithOptions @>

        ExpressionReplacer.createUnsafe <@ fun (m: Match) -> m.Groups @>  <@ Core.Regex.Match.Groups @>
        ExpressionReplacer.createUnsafe <@ fun (m: Match) -> m.Index @>   <@ Core.Regex.Match.Index @>
        ExpressionReplacer.createUnsafe <@ fun (m: Match) -> m.Length @>  <@ Core.Regex.Match.Length @>
        ExpressionReplacer.createUnsafe <@ fun (m: Match) -> m.Success @> <@ Core.Regex.Match.Success @>
        ExpressionReplacer.createUnsafe <@ fun (m: Match) -> m.Value @>   <@ Core.Regex.Match.Value @>

        ExpressionReplacer.createUnsafe <@ fun (ms: MatchCollection) -> ms.Count @> <@ Core.Regex.MatchCollection.Count @>
        ExpressionReplacer.createUnsafe <@ fun (ms: MatchCollection) -> ms.GetEnumerator @> <@ Core.Regex.MatchCollection.GetEnumerator @>
        ExpressionReplacer.createUnsafe <@ fun (ms: MatchCollection, index: int) -> ms.Item(index) @> <@ Core.Regex.MatchCollection.Item @>

        ExpressionReplacer.createUnsafe <@ fun (m: Group) -> m.Length @>  <@ Core.Regex.Group.Length @>
        ExpressionReplacer.createUnsafe <@ fun (m: Group) -> m.Value @>   <@ Core.Regex.Group.Value @>

        ExpressionReplacer.createUnsafe <@ fun (ms: GroupCollection) -> ms.Count @> <@ Core.Regex.GroupCollection.Count @>
        ExpressionReplacer.createUnsafe <@ fun (ms: GroupCollection) -> ms.GetEnumerator @> <@ Core.Regex.GroupCollection.GetEnumerator @>
        ExpressionReplacer.createUnsafe <@ fun (ms: GroupCollection, index: int) -> ms.Item(index) @> <@ Core.Regex.GroupCollection.Item @>
    ]

